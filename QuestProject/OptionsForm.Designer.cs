namespace QuestProject
{
    partial class OptionsForm
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
            this.tlp_Optiond = new System.Windows.Forms.TableLayoutPanel();
            this.lvl_ServerNameOptions = new System.Windows.Forms.Label();
            this.lbl_DatabaseNameOptions = new System.Windows.Forms.Label();
            this.lbl_UsernameOptions = new System.Windows.Forms.Label();
            this.lbl_PasswordOptions = new System.Windows.Forms.Label();
            this.lbl_ParametersOptions = new System.Windows.Forms.Label();
            this.txb_ServerNameOptions = new System.Windows.Forms.TextBox();
            this.txb_DatabaseNameOptions = new System.Windows.Forms.TextBox();
            this.txb_UsernameOptions = new System.Windows.Forms.TextBox();
            this.txb_PasswordOptions = new System.Windows.Forms.TextBox();
            this.rtb_ParametersOptions = new System.Windows.Forms.RichTextBox();
            this.lbl_Number = new System.Windows.Forms.Label();
            this.nud_RecentFiles = new System.Windows.Forms.NumericUpDown();
            this.lbl_Options = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.tlp_Optiond.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecentFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Optiond
            // 
            this.tlp_Optiond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Optiond.ColumnCount = 2;
            this.tlp_Optiond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_Optiond.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlp_Optiond.Controls.Add(this.lvl_ServerNameOptions, 0, 0);
            this.tlp_Optiond.Controls.Add(this.lbl_DatabaseNameOptions, 0, 1);
            this.tlp_Optiond.Controls.Add(this.lbl_UsernameOptions, 0, 2);
            this.tlp_Optiond.Controls.Add(this.lbl_PasswordOptions, 0, 3);
            this.tlp_Optiond.Controls.Add(this.lbl_ParametersOptions, 0, 4);
            this.tlp_Optiond.Controls.Add(this.txb_ServerNameOptions, 1, 0);
            this.tlp_Optiond.Controls.Add(this.txb_DatabaseNameOptions, 1, 1);
            this.tlp_Optiond.Controls.Add(this.txb_UsernameOptions, 1, 2);
            this.tlp_Optiond.Controls.Add(this.txb_PasswordOptions, 1, 3);
            this.tlp_Optiond.Controls.Add(this.rtb_ParametersOptions, 1, 4);
            this.tlp_Optiond.Controls.Add(this.lbl_Number, 0, 5);
            this.tlp_Optiond.Controls.Add(this.nud_RecentFiles, 1, 5);
            this.tlp_Optiond.Location = new System.Drawing.Point(3, 38);
            this.tlp_Optiond.Name = "tlp_Optiond";
            this.tlp_Optiond.RowCount = 6;
            this.tlp_Optiond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_Optiond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_Optiond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_Optiond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_Optiond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_Optiond.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlp_Optiond.Size = new System.Drawing.Size(353, 249);
            this.tlp_Optiond.TabIndex = 0;
            // 
            // lvl_ServerNameOptions
            // 
            this.lvl_ServerNameOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvl_ServerNameOptions.Location = new System.Drawing.Point(3, 0);
            this.lvl_ServerNameOptions.Name = "lvl_ServerNameOptions";
            this.lvl_ServerNameOptions.Size = new System.Drawing.Size(117, 41);
            this.lvl_ServerNameOptions.TabIndex = 0;
            this.lvl_ServerNameOptions.Text = "Server Name:";
            this.lvl_ServerNameOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_DatabaseNameOptions
            // 
            this.lbl_DatabaseNameOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_DatabaseNameOptions.Location = new System.Drawing.Point(3, 41);
            this.lbl_DatabaseNameOptions.Name = "lbl_DatabaseNameOptions";
            this.lbl_DatabaseNameOptions.Size = new System.Drawing.Size(117, 41);
            this.lbl_DatabaseNameOptions.TabIndex = 1;
            this.lbl_DatabaseNameOptions.Text = "Database Name:";
            this.lbl_DatabaseNameOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UsernameOptions
            // 
            this.lbl_UsernameOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UsernameOptions.Location = new System.Drawing.Point(3, 82);
            this.lbl_UsernameOptions.Name = "lbl_UsernameOptions";
            this.lbl_UsernameOptions.Size = new System.Drawing.Size(117, 41);
            this.lbl_UsernameOptions.TabIndex = 2;
            this.lbl_UsernameOptions.Text = "Username:";
            this.lbl_UsernameOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PasswordOptions
            // 
            this.lbl_PasswordOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PasswordOptions.Location = new System.Drawing.Point(3, 123);
            this.lbl_PasswordOptions.Name = "lbl_PasswordOptions";
            this.lbl_PasswordOptions.Size = new System.Drawing.Size(117, 41);
            this.lbl_PasswordOptions.TabIndex = 3;
            this.lbl_PasswordOptions.Text = "Password:";
            this.lbl_PasswordOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ParametersOptions
            // 
            this.lbl_ParametersOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ParametersOptions.Location = new System.Drawing.Point(3, 164);
            this.lbl_ParametersOptions.Name = "lbl_ParametersOptions";
            this.lbl_ParametersOptions.Size = new System.Drawing.Size(117, 41);
            this.lbl_ParametersOptions.TabIndex = 4;
            this.lbl_ParametersOptions.Text = "Parameters (multiline):";
            this.lbl_ParametersOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txb_ServerNameOptions
            // 
            this.txb_ServerNameOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_ServerNameOptions.Location = new System.Drawing.Point(126, 3);
            this.txb_ServerNameOptions.Name = "txb_ServerNameOptions";
            this.txb_ServerNameOptions.Size = new System.Drawing.Size(224, 23);
            this.txb_ServerNameOptions.TabIndex = 5;
            this.txb_ServerNameOptions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_DatabaseNameOptions
            // 
            this.txb_DatabaseNameOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_DatabaseNameOptions.Location = new System.Drawing.Point(126, 44);
            this.txb_DatabaseNameOptions.Name = "txb_DatabaseNameOptions";
            this.txb_DatabaseNameOptions.Size = new System.Drawing.Size(224, 23);
            this.txb_DatabaseNameOptions.TabIndex = 6;
            // 
            // txb_UsernameOptions
            // 
            this.txb_UsernameOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_UsernameOptions.Location = new System.Drawing.Point(126, 85);
            this.txb_UsernameOptions.Name = "txb_UsernameOptions";
            this.txb_UsernameOptions.Size = new System.Drawing.Size(224, 23);
            this.txb_UsernameOptions.TabIndex = 7;
            // 
            // txb_PasswordOptions
            // 
            this.txb_PasswordOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_PasswordOptions.Location = new System.Drawing.Point(126, 126);
            this.txb_PasswordOptions.Name = "txb_PasswordOptions";
            this.txb_PasswordOptions.Size = new System.Drawing.Size(224, 23);
            this.txb_PasswordOptions.TabIndex = 8;
            // 
            // rtb_ParametersOptions
            // 
            this.rtb_ParametersOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_ParametersOptions.Location = new System.Drawing.Point(126, 167);
            this.rtb_ParametersOptions.Name = "rtb_ParametersOptions";
            this.rtb_ParametersOptions.Size = new System.Drawing.Size(224, 35);
            this.rtb_ParametersOptions.TabIndex = 9;
            this.rtb_ParametersOptions.Text = "";
            // 
            // lbl_Number
            // 
            this.lbl_Number.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Number.Location = new System.Drawing.Point(3, 205);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(117, 44);
            this.lbl_Number.TabIndex = 10;
            this.lbl_Number.Text = "Number of recent files:";
            this.lbl_Number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nud_RecentFiles
            // 
            this.nud_RecentFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nud_RecentFiles.Location = new System.Drawing.Point(126, 208);
            this.nud_RecentFiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_RecentFiles.Name = "nud_RecentFiles";
            this.nud_RecentFiles.Size = new System.Drawing.Size(54, 23);
            this.nud_RecentFiles.TabIndex = 11;
            this.nud_RecentFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_RecentFiles.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_Options
            // 
            this.lbl_Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Options.Location = new System.Drawing.Point(12, 0);
            this.lbl_Options.Name = "lbl_Options";
            this.lbl_Options.Size = new System.Drawing.Size(334, 35);
            this.lbl_Options.TabIndex = 1;
            this.lbl_Options.Text = "Please change parameters you would like:";
            this.lbl_Options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Change
            // 
            this.btn_Change.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Change.Location = new System.Drawing.Point(12, 293);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(334, 30);
            this.btn_Change.TabIndex = 2;
            this.btn_Change.Text = "Change default settings";
            this.btn_Change.UseVisualStyleBackColor = true;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 322);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.lbl_Options);
            this.Controls.Add(this.tlp_Optiond);
            this.Name = "OptionsForm";
            this.Text = "OptionsForm";
            this.tlp_Optiond.ResumeLayout(false);
            this.tlp_Optiond.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RecentFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_Optiond;
        private Label lbl_Options;
        private Label lvl_ServerNameOptions;
        private Label lbl_DatabaseNameOptions;
        private Label lbl_UsernameOptions;
        private Label lbl_PasswordOptions;
        private Label lbl_ParametersOptions;
        private TextBox txb_ServerNameOptions;
        private TextBox txb_DatabaseNameOptions;
        private TextBox txb_UsernameOptions;
        private TextBox txb_PasswordOptions;
        private RichTextBox rtb_ParametersOptions;
        private Label lbl_Number;
        private NumericUpDown nud_RecentFiles;
        private Button btn_Change;
    }
}