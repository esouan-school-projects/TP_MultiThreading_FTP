﻿using FTPClient.InfoEntities;
using FTPClient.LocalEntities;
using FTPClient.ServerEntities;

namespace FTPClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStripConnection = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelServer = new System.Windows.Forms.ToolStripLabel();
            this.txtServer = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelUserName = new System.Windows.Forms.ToolStripLabel();
            this.txtUserName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelPassword = new System.Windows.Forms.ToolStripLabel();
            this.txtPassword = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelPort = new System.Windows.Forms.ToolStripLabel();
            this.txtPort = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnection = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.fileTransfertBar = new System.Windows.Forms.ProgressBar();
            this.logWindow = new FTPClient.InfoEntities.LogFTPWindow(this.components);
            this.localTreeView = new FTPClient.LocalEntities.LocalTreeView(this.components);
            this.localListView = new FTPClient.LocalEntities.LocalListView(this.components);
            this.fileNameLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSizeLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileTypeLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastModifiedLocal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serverTreeView = new FTPClient.ServerEntities.ServerTreeView(this.components);
            this.serverListView = new FTPClient.ServerEntities.ServerListView(this.components);
            this.fileNameServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSizeServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileTypeServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastModifiedServer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileRights = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileQueue = new FTPClient.InfoEntities.FileQueue(this.components);
            this.ServerFileLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DistFile = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSizeTransfert = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStripConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "logical_disk_16.png");
            this.imageList.Images.SetKeyName(1, "directory_16.png");
            this.imageList.Images.SetKeyName(2, "file_16.png");
            // 
            // toolStripConnection
            // 
            this.toolStripConnection.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelServer,
            this.txtServer,
            this.toolStripLabelUserName,
            this.txtUserName,
            this.toolStripLabelPassword,
            this.txtPassword,
            this.toolStripLabelPort,
            this.txtPort,
            this.btnConnection});
            this.toolStripConnection.Location = new System.Drawing.Point(0, 0);
            this.toolStripConnection.Name = "toolStripConnection";
            this.toolStripConnection.Size = new System.Drawing.Size(1169, 27);
            this.toolStripConnection.TabIndex = 0;
            this.toolStripConnection.Text = "toolStrip1";
            // 
            // toolStripLabelServer
            // 
            this.toolStripLabelServer.Name = "toolStripLabelServer";
            this.toolStripLabelServer.Size = new System.Drawing.Size(61, 24);
            this.toolStripLabelServer.Text = "Server : ";
            // 
            // txtServer
            // 
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(169, 27);
            this.txtServer.Text = "ftp.kimsavinfo.fr";
            // 
            // toolStripLabelUserName
            // 
            this.toolStripLabelUserName.Name = "toolStripLabelUserName";
            this.toolStripLabelUserName.Size = new System.Drawing.Size(89, 24);
            this.toolStripLabelUserName.Text = "UserName : ";
            // 
            // txtUserName
            // 
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(169, 27);
            this.txtUserName.Text = "kimsavin";
            // 
            // toolStripLabelPassword
            // 
            this.toolStripLabelPassword.Name = "toolStripLabelPassword";
            this.toolStripLabelPassword.Size = new System.Drawing.Size(82, 24);
            this.toolStripLabelPassword.Text = "Password : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(169, 27);
            this.txtPassword.Text = "Se8yBapG";
            // 
            // toolStripLabelPort
            // 
            this.toolStripLabelPort.Name = "toolStripLabelPort";
            this.toolStripLabelPort.Size = new System.Drawing.Size(47, 24);
            this.toolStripLabelPort.Text = "Port : ";
            // 
            // txtPort
            // 
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(76, 27);
            this.txtPort.Text = "21";
            // 
            // btnConnection
            // 
            this.btnConnection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnection.Image = global::FTPClient.Properties.Resources.connexion;
            this.btnConnection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(23, 24);
            this.btnConnection.Text = "toolStripButton1";
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 795);
            this.splitContainer1.SplitterDistance = 681;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.logWindow);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1169, 681);
            this.splitContainer2.SplitterDistance = 123;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer3.Size = new System.Drawing.Size(1169, 554);
            this.splitContainer3.SplitterDistance = 567;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.localTreeView);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.localListView);
            this.splitContainer4.Size = new System.Drawing.Size(567, 554);
            this.splitContainer4.SplitterDistance = 293;
            this.splitContainer4.SplitterWidth = 5;
            this.splitContainer4.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.serverTreeView);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.serverListView);
            this.splitContainer5.Size = new System.Drawing.Size(598, 554);
            this.splitContainer5.SplitterDistance = 293;
            this.splitContainer5.SplitterWidth = 5;
            this.splitContainer5.TabIndex = 0;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.fileTransfertBar);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.fileQueue);
            this.splitContainer6.Size = new System.Drawing.Size(1169, 110);
            this.splitContainer6.SplitterDistance = 34;
            this.splitContainer6.SplitterWidth = 5;
            this.splitContainer6.TabIndex = 0;
            // 
            // fileTransfertBar
            // 
            this.fileTransfertBar.Location = new System.Drawing.Point(4, 4);
            this.fileTransfertBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileTransfertBar.Name = "fileTransfertBar";
            this.fileTransfertBar.Size = new System.Drawing.Size(1161, 28);
            this.fileTransfertBar.TabIndex = 0;
            // 
            // logWindow
            // 
            this.logWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logWindow.Location = new System.Drawing.Point(0, 0);
            this.logWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logWindow.Name = "logWindow";
            this.logWindow.ReadOnly = true;
            this.logWindow.Size = new System.Drawing.Size(1169, 123);
            this.logWindow.TabIndex = 0;
            this.logWindow.Text = "";
            // 
            // localTreeView
            // 
            this.localTreeView.AllowDrop = true;
            this.localTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localTreeView.ImageIndex = 0;
            this.localTreeView.ImageList = this.imageList;
            this.localTreeView.Location = new System.Drawing.Point(0, 0);
            this.localTreeView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localTreeView.Name = "localTreeView";
            this.localTreeView.SelectedImageIndex = 0;
            this.localTreeView.Size = new System.Drawing.Size(567, 293);
            this.localTreeView.TabIndex = 0;
            this.localTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewLocal_NodeMouseDoubleClick);
            // 
            // localListView
            // 
            this.localListView.AllowDrop = true;
            this.localListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameLocal,
            this.fileSizeLocal,
            this.fileTypeLocal,
            this.lastModifiedLocal});
            this.localListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localListView.Location = new System.Drawing.Point(0, 0);
            this.localListView.Margin = new System.Windows.Forms.Padding(4);
            this.localListView.Name = "localListView";
            this.localListView.Size = new System.Drawing.Size(567, 256);
            this.localListView.SmallImageList = this.imageList;
            this.localListView.TabIndex = 1;
            this.localListView.UseCompatibleStateImageBehavior = false;
            this.localListView.View = System.Windows.Forms.View.Details;
            this.localListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewLocal_ItemDrag);
            this.localListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.localListView_MouseDoubleClick);
            this.localListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewLocal_DragDrop);
            this.localListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewLocal_DragEnter);
            // 
            // fileNameLocal
            // 
            this.fileNameLocal.Text = "File Name";
            this.fileNameLocal.Width = 112;
            // 
            // fileSizeLocal
            // 
            this.fileSizeLocal.Text = "File Size";
            this.fileSizeLocal.Width = 85;
            // 
            // fileTypeLocal
            // 
            this.fileTypeLocal.Text = "File Type";
            this.fileTypeLocal.Width = 94;
            // 
            // lastModifiedLocal
            // 
            this.lastModifiedLocal.Text = "Last Modified";
            this.lastModifiedLocal.Width = 127;
            // 
            // serverTreeView
            // 
            this.serverTreeView.AllowDrop = true;
            this.serverTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverTreeView.ImageIndex = 0;
            this.serverTreeView.ImageList = this.imageList;
            this.serverTreeView.Location = new System.Drawing.Point(0, 0);
            this.serverTreeView.Margin = new System.Windows.Forms.Padding(4);
            this.serverTreeView.Name = "serverTreeView";
            this.serverTreeView.SelectedImageIndex = 0;
            this.serverTreeView.Size = new System.Drawing.Size(598, 293);
            this.serverTreeView.TabIndex = 0;
            this.serverTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewServer_NodeMouseDoubleClick);
            // 
            // serverListView
            // 
            this.serverListView.AllowDrop = true;
            this.serverListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameServer,
            this.fileSizeServer,
            this.fileTypeServer,
            this.lastModifiedServer,
            this.fileRights,
            this.fileOwner,
            this.fileGroup});
            this.serverListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serverListView.Location = new System.Drawing.Point(0, 0);
            this.serverListView.Margin = new System.Windows.Forms.Padding(4);
            this.serverListView.Name = "serverListView";
            this.serverListView.Size = new System.Drawing.Size(598, 256);
            this.serverListView.SmallImageList = this.imageList;
            this.serverListView.TabIndex = 0;
            this.serverListView.UseCompatibleStateImageBehavior = false;
            this.serverListView.View = System.Windows.Forms.View.Details;
            this.serverListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewLocal_ItemDrag);
            this.serverListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.serverListView_MouseDoubleClick);
            this.serverListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listViewServer_DragDrop);
            this.serverListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewServer_DragEnter);
            // 
            // fileNameServer
            // 
            this.fileNameServer.Text = "File Name";
            this.fileNameServer.Width = 112;
            // 
            // fileSizeServer
            // 
            this.fileSizeServer.Text = "File Size";
            this.fileSizeServer.Width = 85;
            // 
            // fileTypeServer
            // 
            this.fileTypeServer.Text = "File Type";
            this.fileTypeServer.Width = 94;
            // 
            // lastModifiedServer
            // 
            this.lastModifiedServer.Text = "Last Modified";
            this.lastModifiedServer.Width = 127;
            // 
            // fileRights
            // 
            this.fileRights.Text = "Rights";
            // 
            // fileOwner
            // 
            this.fileOwner.Text = "Owner";
            // 
            // fileGroup
            // 
            this.fileGroup.Text = "Group";
            // 
            // fileQueue
            // 
            this.fileQueue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServerFileLocation,
            this.Direction,
            this.DistFile,
            this.FileSizeTransfert,
            this.Time});
            this.fileQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileQueue.Location = new System.Drawing.Point(0, 0);
            this.fileQueue.Margin = new System.Windows.Forms.Padding(4);
            this.fileQueue.Name = "fileQueue";
            this.fileQueue.Size = new System.Drawing.Size(1169, 71);
            this.fileQueue.TabIndex = 0;
            this.fileQueue.UseCompatibleStateImageBehavior = false;
            this.fileQueue.View = System.Windows.Forms.View.Details;
            // 
            // ServerFileLocation
            // 
            this.ServerFileLocation.Text = "Server / File Location";
            this.ServerFileLocation.Width = 275;
            // 
            // Direction
            // 
            this.Direction.Text = "Direction";
            // 
            // DistFile
            // 
            this.DistFile.Text = "Dist File";
            this.DistFile.Width = 281;
            // 
            // FileSizeTransfert
            // 
            this.FileSizeTransfert.Text = "Size";
            this.FileSizeTransfert.Width = 110;
            // 
            // Time
            // 
            this.Time.Text = "Time";
            this.Time.Width = 147;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 822);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStripConnection);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "FTP Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripConnection.ResumeLayout(false);
            this.toolStripConnection.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStrip toolStripConnection;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private LocalTreeView localTreeView;
        private System.Windows.Forms.ToolStripLabel toolStripLabelServer;
        private System.Windows.Forms.ToolStripTextBox txtServer;
        private System.Windows.Forms.ToolStripLabel toolStripLabelUserName;
        private System.Windows.Forms.ToolStripTextBox txtUserName;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPassword;
        private System.Windows.Forms.ToolStripTextBox txtPassword;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPort;
        private System.Windows.Forms.ToolStripTextBox txtPort;
        private System.Windows.Forms.ToolStripButton btnConnection;
        private ServerTreeView serverTreeView;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private ServerListView serverListView;
        private System.Windows.Forms.ColumnHeader fileNameServer;
        private System.Windows.Forms.ColumnHeader fileSizeServer;
        private System.Windows.Forms.ColumnHeader fileTypeServer;
        private System.Windows.Forms.ColumnHeader lastModifiedServer;
        private LocalListView localListView;
        private System.Windows.Forms.ColumnHeader fileNameLocal;
        private System.Windows.Forms.ColumnHeader fileSizeLocal;
        private System.Windows.Forms.ColumnHeader fileTypeLocal;
        private System.Windows.Forms.ColumnHeader lastModifiedLocal;
        private System.Windows.Forms.ColumnHeader fileRights;
        private System.Windows.Forms.ColumnHeader fileOwner;
        private System.Windows.Forms.ColumnHeader fileGroup;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private FileQueue fileQueue;
        private System.Windows.Forms.ColumnHeader ServerFileLocation;
        private System.Windows.Forms.ColumnHeader Direction;
        private System.Windows.Forms.ColumnHeader DistFile;
        private System.Windows.Forms.ColumnHeader FileSizeTransfert;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ProgressBar fileTransfertBar;
        private LogFTPWindow logWindow;
    }
}

