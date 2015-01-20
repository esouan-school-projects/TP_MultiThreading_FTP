﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTPClient.LocalEntities
{
    public partial class LocalListView : ListView
    {
        public LocalListView()
        {
            InitializeComponent();
        }

        public LocalListView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void AddItem(FileSystemInfo fileInfo)
        {
            ListViewItem newItem = GenerateItem(fileInfo);
            this.Items.Add(newItem);
        }

        public void AddItems(List<DirectoryInfo> directoriesToAdd)
        {
            foreach (DirectoryInfo directory in directoriesToAdd)
            {
                AddItem(directory);
            }
        }

        public void AddItems(List<FileInfo> filesToAdd)
        {
            foreach (FileInfo file in filesToAdd)
            {
                AddItem(file);
            }
        }

        public ListViewItem GenerateItem(FileSystemInfo fileInfo)
        {
            ListViewItem newItem = new ListViewItem(fileInfo.Name, 0);
            newItem.Name = fileInfo.Name;
            newItem.Tag = fileInfo;
            newItem.ImageIndex = AssignImage(fileInfo.Extension);

            ListViewItem.ListViewSubItem[] newSubItems = new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem(newItem, RetrieveSize(fileInfo)),
                new ListViewItem.ListViewSubItem(newItem, fileInfo.Extension), 
                new ListViewItem.ListViewSubItem(newItem, fileInfo.LastAccessTime.ToShortDateString())
            };
            newItem.SubItems.AddRange(newSubItems);

            return newItem;
        }

        public void AddItem(ListViewItem itemToAdd) {
            this.Items.Add(itemToAdd);
        }

        private string RetrieveSize(FileSystemInfo fileInfo)
        {
            string size = "";

            try
            {
                FileInfo fileDetails = (FileInfo)fileInfo;
                size = fileDetails.Length.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception + " : The file is a directory so its size is not displayed");
            }

            return size;
        }

        private int AssignImage(string fileExtension)
        {
            int imageIndex = 1;

            if (!fileExtension.Equals(""))
                imageIndex = 2;

            return imageIndex;
        }

        public void ClearItems()
        {
            this.Items.Clear();
        }

        public ListViewItem GetPointedItem(Point point)
        {
            Point pointListOrigin = this.PointToClient(point);
            ListViewItem targetFile = this.GetItemAt(pointListOrigin.X, pointListOrigin.Y);

            return targetFile;
        }

        public string GetDirecoryNamePointed(Point point)
        {
            string name = "";

            ListViewItem targetFile = GetPointedItem(point);
            if (IsADirectory(targetFile))
            {
                FileSystemInfo targetFileInfo = (FileSystemInfo)targetFile.Tag;
                name = targetFileInfo.Name;
            }

            return name;
        }

        private bool IsADirectory(ListViewItem item)
        {
            bool isADirectory = false;

            if (item.ImageIndex == 0 || item.ImageIndex == 1)
            {
                isADirectory = true;
            }

            return isADirectory;
        }
    }
}
