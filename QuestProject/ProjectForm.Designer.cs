namespace QuestProject
{
    partial class ProjectForm
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
            this.lbl_EnterText = new System.Windows.Forms.Label();
            this.lbl_WelcomeProjectForm = new System.Windows.Forms.Label();
            this.tlp_ProjectParameters = new System.Windows.Forms.TableLayoutPanel();
            this.btn_New = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_SaveAs = new System.Windows.Forms.Button();
            this.lbl_ServerName = new System.Windows.Forms.Label();
            this.lbl_DatabaseName = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Parameters = new System.Windows.Forms.Label();
            this.txb_ServerName = new System.Windows.Forms.TextBox();
            this.txb_DatabaseName = new System.Windows.Forms.TextBox();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Parameters = new System.Windows.Forms.RichTextBox();
            this.tlp_ProjectParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_EnterText
            // 
            this.lbl_EnterText.Location = new System.Drawing.Point(12, 40);
            this.lbl_EnterText.Name = "lbl_EnterText";
            this.lbl_EnterText.Size = new System.Drawing.Size(235, 34);
            this.lbl_EnterText.TabIndex = 1;
            this.lbl_EnterText.Text = "Please enter next parameters:";
            this.lbl_EnterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_EnterText.UseWaitCursor = true;
            // 
            // lbl_WelcomeProjectForm
            // 
            this.lbl_WelcomeProjectForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_WelcomeProjectForm.Location = new System.Drawing.Point(15, 9);
            this.lbl_WelcomeProjectForm.Name = "lbl_WelcomeProjectForm";
            this.lbl_WelcomeProjectForm.Size = new System.Drawing.Size(466, 31);
            this.lbl_WelcomeProjectForm.TabIndex = 2;
            this.lbl_WelcomeProjectForm.Text = "Project info";
            this.lbl_WelcomeProjectForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_ProjectParameters
            // 
            this.tlp_ProjectParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_ProjectParameters.ColumnCount = 3;
            this.tlp_ProjectParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ProjectParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ProjectParameters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ProjectParameters.Controls.Add(this.btn_New, 2, 0);
            this.tlp_ProjectParameters.Controls.Add(this.btn_Load, 2, 1);
            this.tlp_ProjectParameters.Controls.Add(this.btn_Save, 2, 3);
            this.tlp_ProjectParameters.Controls.Add(this.btn_SaveAs, 2, 4);
            this.tlp_ProjectParameters.Controls.Add(this.lbl_ServerName, 0, 0);
            this.tlp_ProjectParameters.Controls.Add(this.lbl_DatabaseName, 0, 1);
            this.tlp_ProjectParameters.Controls.Add(this.lbl_Username, 0, 2);
            this.tlp_ProjectParameters.Controls.Add(this.lbl_Password, 0, 3);
            this.tlp_ProjectParameters.Controls.Add(this.lbl_Parameters, 0, 4);
            this.tlp_ProjectParameters.Controls.Add(this.txb_ServerName, 1, 0);
            this.tlp_ProjectParameters.Controls.Add(this.txb_DatabaseName, 1, 1);
            this.tlp_ProjectParameters.Controls.Add(this.txb_Username, 1, 2);
            this.tlp_ProjectParameters.Controls.Add(this.txb_Password, 1, 3);
            this.tlp_ProjectParameters.Controls.Add(this.txb_Parameters, 1, 4);
            this.tlp_ProjectParameters.Location = new System.Drawing.Point(12, 77);
            this.tlp_ProjectParameters.Name = "tlp_ProjectParameters";
            this.tlp_ProjectParameters.RowCount = 5;
            this.tlp_ProjectParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_ProjectParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_ProjectParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_ProjectParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_ProjectParameters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_ProjectParameters.Size = new System.Drawing.Size(466, 182);
            this.tlp_ProjectParameters.TabIndex = 7;
            // 
            // btn_New
            // 
            this.btn_New.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_New.Location = new System.Drawing.Point(352, 3);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(111, 30);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "New";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Load.Location = new System.Drawing.Point(352, 39);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(111, 30);
            this.btn_Load.TabIndex = 1;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(352, 111);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(111, 30);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_SaveAs
            // 
            this.btn_SaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveAs.Location = new System.Drawing.Point(352, 147);
            this.btn_SaveAs.Name = "btn_SaveAs";
            this.btn_SaveAs.Size = new System.Drawing.Size(111, 32);
            this.btn_SaveAs.TabIndex = 3;
            this.btn_SaveAs.Text = "Save As";
            this.btn_SaveAs.UseVisualStyleBackColor = true;
            this.btn_SaveAs.Click += new System.EventHandler(this.btn_SaveAs_Click);
            // 
            // lbl_ServerName
            // 
            this.lbl_ServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ServerName.Location = new System.Drawing.Point(3, 0);
            this.lbl_ServerName.Name = "lbl_ServerName";
            this.lbl_ServerName.Size = new System.Drawing.Size(110, 36);
            this.lbl_ServerName.TabIndex = 4;
            this.lbl_ServerName.Text = "Server Name:";
            this.lbl_ServerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_DatabaseName
            // 
            this.lbl_DatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DatabaseName.Location = new System.Drawing.Point(3, 36);
            this.lbl_DatabaseName.Name = "lbl_DatabaseName";
            this.lbl_DatabaseName.Size = new System.Drawing.Size(110, 36);
            this.lbl_DatabaseName.TabIndex = 5;
            this.lbl_DatabaseName.Text = "Database name:";
            this.lbl_DatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Username.Location = new System.Drawing.Point(3, 72);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(110, 36);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Username:";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Password.Location = new System.Drawing.Point(3, 108);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(110, 36);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password:";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Parameters
            // 
            this.lbl_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Parameters.Location = new System.Drawing.Point(3, 144);
            this.lbl_Parameters.Name = "lbl_Parameters";
            this.lbl_Parameters.Size = new System.Drawing.Size(110, 38);
            this.lbl_Parameters.TabIndex = 8;
            this.lbl_Parameters.Text = "Parameters (multiline):";
            this.lbl_Parameters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txb_ServerName
            // 
            this.txb_ServerName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txb_ServerName.Location = new System.Drawing.Point(119, 3);
            this.txb_ServerName.Name = "txb_ServerName";
            this.txb_ServerName.Size = new System.Drawing.Size(227, 23);
            this.txb_ServerName.TabIndex = 9;
            // 
            // txb_DatabaseName
            // 
            this.txb_DatabaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_DatabaseName.Location = new System.Drawing.Point(119, 39);
            this.txb_DatabaseName.Name = "txb_DatabaseName";
            this.txb_DatabaseName.Size = new System.Drawing.Size(227, 23);
            this.txb_DatabaseName.TabIndex = 10;
            // 
            // txb_Username
            // 
            this.txb_Username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Username.Location = new System.Drawing.Point(119, 75);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(227, 23);
            this.txb_Username.TabIndex = 11;
            // 
            // txb_Password
            // 
            this.txb_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Password.Location = new System.Drawing.Point(119, 111);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(227, 23);
            this.txb_Password.TabIndex = 12;
            // 
            // txb_Parameters
            // 
            this.txb_Parameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Parameters.Location = new System.Drawing.Point(119, 147);
            this.txb_Parameters.Name = "txb_Parameters";
            this.txb_Parameters.Size = new System.Drawing.Size(227, 32);
            this.txb_Parameters.TabIndex = 13;
            this.txb_Parameters.Text = "";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 271);
            this.Controls.Add(this.tlp_ProjectParameters);
            this.Controls.Add(this.lbl_WelcomeProjectForm);
            this.Controls.Add(this.lbl_EnterText);
            this.MinimumSize = new System.Drawing.Size(390, 290);
            this.Name = "ProjectForm";
            this.Text = "ProjectForm";
            this.tlp_ProjectParameters.ResumeLayout(false);
            this.tlp_ProjectParameters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_EnterText;
        private Label lbl_WelcomeProjectForm;
        private TableLayoutPanel tlp_ProjectParameters;
        private Button btn_New;
        private Button btn_Load;
        private Button btn_Save;
        private Button btn_SaveAs;
        private Label lbl_ServerName;
        private Label lbl_DatabaseName;
        private Label lbl_Username;
        private Label lbl_Password;
        private Label lbl_Parameters;
        private TextBox txb_ServerName;
        private TextBox txb_DatabaseName;
        private TextBox txb_Username;
        private TextBox txb_Password;
        private RichTextBox txb_Parameters;
    }
}