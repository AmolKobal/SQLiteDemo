namespace SQLiteDemo
{
    partial class frmScores
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
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.btnAddScore = new System.Windows.Forms.Button();
            this.btnShowScore = new System.Windows.Forms.Button();
            this.lstScore = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.grpNewScore = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpNewScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(38, 32);
            this.btnTestConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(195, 28);
            this.btnTestConnection.TabIndex = 0;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnAddScore
            // 
            this.btnAddScore.Location = new System.Drawing.Point(271, 74);
            this.btnAddScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddScore.Name = "btnAddScore";
            this.btnAddScore.Size = new System.Drawing.Size(195, 28);
            this.btnAddScore.TabIndex = 0;
            this.btnAddScore.Text = "Add Score";
            this.btnAddScore.UseVisualStyleBackColor = true;
            this.btnAddScore.Click += new System.EventHandler(this.btnAddScore_Click);
            // 
            // btnShowScore
            // 
            this.btnShowScore.Location = new System.Drawing.Point(38, 113);
            this.btnShowScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowScore.Name = "btnShowScore";
            this.btnShowScore.Size = new System.Drawing.Size(195, 28);
            this.btnShowScore.TabIndex = 0;
            this.btnShowScore.Text = "Show Score";
            this.btnShowScore.UseVisualStyleBackColor = true;
            this.btnShowScore.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstScore
            // 
            this.lstScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstScore.FullRowSelect = true;
            this.lstScore.HideSelection = false;
            this.lstScore.Location = new System.Drawing.Point(283, 159);
            this.lstScore.Margin = new System.Windows.Forms.Padding(4);
            this.lstScore.Name = "lstScore";
            this.lstScore.Size = new System.Drawing.Size(488, 222);
            this.lstScore.TabIndex = 1;
            this.lstScore.UseCompatibleStateImageBehavior = false;
            this.lstScore.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Score";
            this.columnHeader2.Width = 138;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(65, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(401, 22);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(65, 54);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(146, 22);
            this.txtScore.TabIndex = 3;
            // 
            // grpNewScore
            // 
            this.grpNewScore.Controls.Add(this.txtName);
            this.grpNewScore.Controls.Add(this.txtScore);
            this.grpNewScore.Controls.Add(this.btnAddScore);
            this.grpNewScore.Controls.Add(this.label2);
            this.grpNewScore.Controls.Add(this.label1);
            this.grpNewScore.Location = new System.Drawing.Point(283, 23);
            this.grpNewScore.Name = "grpNewScore";
            this.grpNewScore.Size = new System.Drawing.Size(488, 118);
            this.grpNewScore.TabIndex = 4;
            this.grpNewScore.TabStop = false;
            this.grpNewScore.Text = "Add Score";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(38, 195);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(195, 28);
            this.btnRemove.TabIndex = 0;
            this.btnRemove.Text = "Remove Score";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 405);
            this.Controls.Add(this.grpNewScore);
            this.Controls.Add(this.lstScore);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnShowScore);
            this.Controls.Add(this.btnTestConnection);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmScores";
            this.Text = "Scores";
            this.grpNewScore.ResumeLayout(false);
            this.grpNewScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnAddScore;
        private System.Windows.Forms.Button btnShowScore;
        private System.Windows.Forms.ListView lstScore;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.GroupBox grpNewScore;
        private System.Windows.Forms.Button btnRemove;
    }
}

