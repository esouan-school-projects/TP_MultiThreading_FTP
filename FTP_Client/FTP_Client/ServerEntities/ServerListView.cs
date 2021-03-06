﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FTP_Client.ServerEntities
{
    public class ServerListView : ListView
    {
        public ServerListView()
        {
        }

        public void AddItem(TreeNode node, String displayName)
        {
            FileServer fileServer = (FileServer)node.Tag;

            string size = fileServer.GetSize().ToString();
            string extension = fileServer.GetDataType();
            string date = fileServer.GetLastModifiedDate();
            string rights = fileServer.GetRights();
            string owner = fileServer.GetOwner();
            string group = fileServer.GetGroup();

            ListViewItem item = new ListViewItem(displayName, 0);
            item.Name = fileServer.GetName();
            item.Tag = node;
            item.ImageIndex = AssignImage(extension);

            ListViewItem.ListViewSubItem[] subItems = new ListViewItem.ListViewSubItem[]
                    {
                        new ListViewItem.ListViewSubItem(item, size),
                        new ListViewItem.ListViewSubItem(item, extension), 
                        new ListViewItem.ListViewSubItem(item, date),
                        new ListViewItem.ListViewSubItem(item, rights),
                        new ListViewItem.ListViewSubItem(item, owner),
                        new ListViewItem.ListViewSubItem(item, group)
                    };
            ;
            item.SubItems.AddRange(subItems);

            this.Items.Add(item);
        }

        private int AssignImage(string extension)
        {
            int imageIndex = 2;

            if (extension.Equals("Directory"))
            {
                imageIndex = 1;
            }

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
                FileServer targetFileInfo = (FileServer)targetFile.Tag;
                name = targetFileInfo.GetName();
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
