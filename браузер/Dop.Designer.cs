﻿
namespace браузер
{
    partial class Dop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Зиннатуллина Регина Гамировна");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Шакирова Индира Ильшатовна");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Макурин Никита Михайлович");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("09-121", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Лань Ванцзы Чжань");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Захарченко Марк Игоревич");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Яканина Полина Евгеньевна");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("09-122", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Фамилия = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Имя = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Описание = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            this.splitContainer2.Size = new System.Drawing.Size(266, 450);
            this.splitContainer2.SplitterDistance = 225;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "первый";
            treeNode1.Text = "Зиннатуллина Регина Гамировна";
            treeNode2.Name = "Второй";
            treeNode2.Text = "Шакирова Индира Ильшатовна";
            treeNode3.Name = "третий";
            treeNode3.Text = "Макурин Никита Михайлович";
            treeNode4.Name = "Узел1";
            treeNode4.Text = "09-121";
            treeNode5.Name = "втрПервый";
            treeNode5.Text = "Лань Ванцзы Чжань";
            treeNode6.Name = "втрВторой";
            treeNode6.Text = "Захарченко Марк Игоревич";
            treeNode7.Name = "втрТретий";
            treeNode7.Text = "Яканина Полина Евгеньевна";
            treeNode8.Name = "Узел1";
            treeNode8.Text = "09-122";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(266, 225);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Фамилия,
            this.Имя,
            this.Описание});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(530, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // Фамилия
            // 
            this.Фамилия.Frozen = true;
            this.Фамилия.HeaderText = "Фимилия";
            this.Фамилия.MinimumWidth = 6;
            this.Фамилия.Name = "Фамилия";
            this.Фамилия.Width = 99;
            // 
            // Имя
            // 
            this.Имя.Frozen = true;
            this.Имя.HeaderText = "Имя";
            this.Имя.MinimumWidth = 6;
            this.Имя.Name = "Имя";
            this.Имя.Width = 64;
            // 
            // Описание
            // 
            this.Описание.Frozen = true;
            this.Описание.HeaderText = "Описание";
            this.Описание.MinimumWidth = 6;
            this.Описание.Name = "Описание";
            this.Описание.Width = 103;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Dop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фамилия;
        private System.Windows.Forms.DataGridViewTextBoxColumn Имя;
        private System.Windows.Forms.DataGridViewTextBoxColumn Описание;
    }
}