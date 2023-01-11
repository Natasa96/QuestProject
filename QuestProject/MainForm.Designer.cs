namespace QuestProject
{
    partial class QuestProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_Selection = new System.Windows.Forms.Label();
            this.btn_CreateNewProject = new System.Windows.Forms.Button();
            this.btn_Load = new System.Windows.Forms.Button();
            this.cmb_RecentProjects = new System.Windows.Forms.ComboBox();
            this.btn_Options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Welcome.Location = new System.Drawing.Point(12, 9);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(260, 25);
            this.lbl_Welcome.TabIndex = 0;
            this.lbl_Welcome.Text = "Welcome to project creating app";
            this.lbl_Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Welcome.UseWaitCursor = true;
            // 
            // lbl_Selection
            // 
            this.lbl_Selection.Location = new System.Drawing.Point(12, 49);
            this.lbl_Selection.Name = "lbl_Selection";
            this.lbl_Selection.Size = new System.Drawing.Size(260, 30);
            this.lbl_Selection.TabIndex = 1;
            this.lbl_Selection.Text = "Please select your next action";
            this.lbl_Selection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Selection.UseWaitCursor = true;
            // 
            // btn_CreateNewProject
            // 
            this.btn_CreateNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateNewProject.Location = new System.Drawing.Point(12, 82);
            this.btn_CreateNewProject.Name = "btn_CreateNewProject";
            this.btn_CreateNewProject.Size = new System.Drawing.Size(260, 30);
            this.btn_CreateNewProject.TabIndex = 2;
            this.btn_CreateNewProject.Text = "Create New Project";
            this.btn_CreateNewProject.UseVisualStyleBackColor = true;
            this.btn_CreateNewProject.UseWaitCursor = true;
            this.btn_CreateNewProject.Click += new System.EventHandler(this.btn_CreateNewProject_Click);
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Load.Location = new System.Drawing.Point(12, 118);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(260, 32);
            this.btn_Load.TabIndex = 3;
            this.btn_Load.Text = "Load Exisiting Project";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.UseWaitCursor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // cmb_RecentProjects
            // 
            this.cmb_RecentProjects.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_RecentProjects.FormattingEnabled = true;
            this.cmb_RecentProjects.Location = new System.Drawing.Point(12, 156);
            this.cmb_RecentProjects.Name = "cmb_RecentProjects";
            this.cmb_RecentProjects.Size = new System.Drawing.Size(260, 23);
            this.cmb_RecentProjects.TabIndex = 4;
            this.cmb_RecentProjects.UseWaitCursor = true;
            this.cmb_RecentProjects.TextChanged += new System.EventHandler(this.cmb_RecentProjects_TextChanged);
            // 
            // btn_Options
            // 
            this.btn_Options.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Options.Location = new System.Drawing.Point(12, 269);
            this.btn_Options.Name = "btn_Options";
            this.btn_Options.Size = new System.Drawing.Size(260, 30);
            this.btn_Options.TabIndex = 5;
            this.btn_Options.Text = "Options";
            this.btn_Options.UseVisualStyleBackColor = true;
            this.btn_Options.UseWaitCursor = true;
            this.btn_Options.Click += new System.EventHandler(this.btn_Options_Click);
            // 
            // QuestProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.btn_Options);
            this.Controls.Add(this.cmb_RecentProjects);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.btn_CreateNewProject);
            this.Controls.Add(this.lbl_Selection);
            this.Controls.Add(this.lbl_Welcome);
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "QuestProject";
            this.Text = "QuestProject";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_Welcome;
        private Label lbl_Selection;
        private Button btn_CreateNewProject;
        private Button btn_Load;
        private ComboBox cmb_RecentProjects;
        private Button btn_Options;
    }
}