namespace samp_cfg
{
    partial class Form2
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
            this.server_list = new System.Windows.Forms.ListBox();
            this.folder_list = new System.Windows.Forms.ListBox();
            this.bt_up = new System.Windows.Forms.Button();
            this.bt_down = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_rem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_manual = new System.Windows.Forms.Button();
            this.data_gmode = new System.Windows.Forms.TextBox();
            this.data_repeat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_repeat)).BeginInit();
            this.SuspendLayout();
            // 
            // server_list
            // 
            this.server_list.FormattingEnabled = true;
            this.server_list.Location = new System.Drawing.Point(12, 41);
            this.server_list.Name = "server_list";
            this.server_list.Size = new System.Drawing.Size(162, 290);
            this.server_list.TabIndex = 0;
            // 
            // folder_list
            // 
            this.folder_list.FormattingEnabled = true;
            this.folder_list.Location = new System.Drawing.Point(261, 41);
            this.folder_list.Name = "folder_list";
            this.folder_list.Size = new System.Drawing.Size(162, 316);
            this.folder_list.TabIndex = 0;
            // 
            // bt_up
            // 
            this.bt_up.Location = new System.Drawing.Point(12, 363);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(79, 21);
            this.bt_up.TabIndex = 1;
            this.bt_up.Text = "Move Up";
            this.bt_up.UseVisualStyleBackColor = true;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // bt_down
            // 
            this.bt_down.Location = new System.Drawing.Point(95, 363);
            this.bt_down.Name = "bt_down";
            this.bt_down.Size = new System.Drawing.Size(79, 21);
            this.bt_down.TabIndex = 1;
            this.bt_down.Text = "Move Down";
            this.bt_down.UseVisualStyleBackColor = true;
            this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(180, 166);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 24);
            this.bt_add.TabIndex = 2;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_rem
            // 
            this.bt_rem.Location = new System.Drawing.Point(180, 196);
            this.bt_rem.Name = "bt_rem";
            this.bt_rem.Size = new System.Drawing.Size(75, 24);
            this.bt_rem.TabIndex = 2;
            this.bt_rem.Text = "Remove";
            this.bt_rem.UseVisualStyleBackColor = true;
            this.bt_rem.Click += new System.EventHandler(this.bt_rem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "In server.cfg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(261, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "In Folder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(260, 363);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(79, 21);
            this.bt_cancel.TabIndex = 1;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(343, 363);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(79, 21);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "Save";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // bt_manual
            // 
            this.bt_manual.Location = new System.Drawing.Point(140, 337);
            this.bt_manual.Name = "bt_manual";
            this.bt_manual.Size = new System.Drawing.Size(34, 21);
            this.bt_manual.TabIndex = 4;
            this.bt_manual.Text = "Add";
            this.bt_manual.UseVisualStyleBackColor = true;
            this.bt_manual.Click += new System.EventHandler(this.bt_manual_Click);
            // 
            // data_gmode
            // 
            this.data_gmode.Location = new System.Drawing.Point(12, 338);
            this.data_gmode.Name = "data_gmode";
            this.data_gmode.Size = new System.Drawing.Size(122, 20);
            this.data_gmode.TabIndex = 5;
            // 
            // data_repeat
            // 
            this.data_repeat.Location = new System.Drawing.Point(197, 125);
            this.data_repeat.Name = "data_repeat";
            this.data_repeat.Size = new System.Drawing.Size(45, 20);
            this.data_repeat.TabIndex = 6;
            this.data_repeat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Repeat";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 392);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.data_repeat);
            this.Controls.Add(this.data_gmode);
            this.Controls.Add(this.bt_manual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_rem);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_down);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.folder_list);
            this.Controls.Add(this.server_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose Items";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_repeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Button bt_down;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_rem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        public System.Windows.Forms.ListBox server_list;
        public System.Windows.Forms.ListBox folder_list;
        private System.Windows.Forms.Button bt_manual;
        private System.Windows.Forms.TextBox data_gmode;
        private System.Windows.Forms.NumericUpDown data_repeat;
        private System.Windows.Forms.Label label3;
    }
}