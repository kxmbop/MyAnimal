namespace MyAnimal
{
    partial class Hobbies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hobbies));
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hobbyGridView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.HName = new System.Windows.Forms.TextBox();
            this.savehubbt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.HId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.hobbyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "--- ADD HOBBIES ---";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(213, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 35);
            this.label9.TabIndex = 54;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // hobbyGridView
            // 
            this.hobbyGridView.AllowUserToAddRows = false;
            this.hobbyGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.hobbyGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hobbyGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.hobbyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hobbyGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hobbyGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.hobbyGridView.Location = new System.Drawing.Point(24, 163);
            this.hobbyGridView.Name = "hobbyGridView";
            this.hobbyGridView.RowHeadersVisible = false;
            this.hobbyGridView.RowHeadersWidth = 51;
            this.hobbyGridView.RowTemplate.Height = 25;
            this.hobbyGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hobbyGridView.Size = new System.Drawing.Size(206, 131);
            this.hobbyGridView.TabIndex = 55;
            this.hobbyGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hobbyGridView_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(24, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 57;
            this.label8.Text = "Hobby";
            // 
            // HName
            // 
            this.HName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.HName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HName.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HName.Location = new System.Drawing.Point(24, 91);
            this.HName.Name = "HName";
            this.HName.Size = new System.Drawing.Size(206, 24);
            this.HName.TabIndex = 56;
            // 
            // savehubbt
            // 
            this.savehubbt.BackColor = System.Drawing.Color.RoyalBlue;
            this.savehubbt.FlatAppearance.BorderSize = 0;
            this.savehubbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savehubbt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savehubbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savehubbt.Location = new System.Drawing.Point(24, 125);
            this.savehubbt.Name = "savehubbt";
            this.savehubbt.Size = new System.Drawing.Size(62, 26);
            this.savehubbt.TabIndex = 60;
            this.savehubbt.Text = "SAVE";
            this.savehubbt.UseVisualStyleBackColor = false;
            this.savehubbt.Click += new System.EventHandler(this.savehubbt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(97, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 26);
            this.button1.TabIndex = 61;
            this.button1.Text = "DEL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(168, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 26);
            this.button2.TabIndex = 62;
            this.button2.Text = "VIEW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // HId
            // 
            this.HId.BackColor = System.Drawing.Color.LightSteelBlue;
            this.HId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HId.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HId.Location = new System.Drawing.Point(213, 64);
            this.HId.Name = "HId";
            this.HId.Size = new System.Drawing.Size(17, 24);
            this.HId.TabIndex = 63;
            this.HId.Visible = false;
            // 
            // Hobbies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(252, 315);
            this.Controls.Add(this.HId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.savehubbt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.HName);
            this.Controls.Add(this.hobbyGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hobbies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hobbies";
            ((System.ComponentModel.ISupportInitialize)(this.hobbyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private Label label9;
        private DataGridView hobbyGridView;
        private Label label8;
        private TextBox HName;
        private Button savehubbt;
        private Button button1;
        private Button button2;
        private TextBox HId;
    }
}