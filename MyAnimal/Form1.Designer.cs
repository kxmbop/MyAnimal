namespace MyAnimal
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.AType = new System.Windows.Forms.ComboBox();
            this.AName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OContact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOBTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AnimalId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.animalGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.edithobby = new System.Windows.Forms.Button();
            this.deletebt = new System.Windows.Forms.Button();
            this.updatebt = new System.Windows.Forms.Button();
            this.savebt = new System.Windows.Forms.Button();
            this.viewbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(24, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 29);
            this.label7.TabIndex = 41;
            this.label7.Text = "--- ANIMAL PROJECT ---";
            // 
            // AType
            // 
            this.AType.AllowDrop = true;
            this.AType.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AType.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AType.FormattingEnabled = true;
            this.AType.Items.AddRange(new object[] {
            "Canine",
            "Feline",
            "Horse"});
            this.AType.Location = new System.Drawing.Point(17, 76);
            this.AType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AType.Name = "AType";
            this.AType.Size = new System.Drawing.Size(232, 25);
            this.AType.TabIndex = 39;
            // 
            // AName
            // 
            this.AName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AName.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AName.Location = new System.Drawing.Point(17, 29);
            this.AName.Name = "AName";
            this.AName.Size = new System.Drawing.Size(232, 24);
            this.AName.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "--------------------------------------";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // OContact
            // 
            this.OContact.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OContact.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OContact.Location = new System.Drawing.Point(17, 238);
            this.OContact.Name = "OContact";
            this.OContact.Size = new System.Drawing.Size(232, 24);
            this.OContact.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Contact No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Date of Birth";
            // 
            // DOBTimePicker
            // 
            this.DOBTimePicker.CalendarMonthBackground = System.Drawing.Color.PeachPuff;
            this.DOBTimePicker.CalendarTitleBackColor = System.Drawing.Color.PeachPuff;
            this.DOBTimePicker.Location = new System.Drawing.Point(17, 128);
            this.DOBTimePicker.Name = "DOBTimePicker";
            this.DOBTimePicker.Size = new System.Drawing.Size(232, 23);
            this.DOBTimePicker.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Owner Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Animal Type";
            // 
            // OName
            // 
            this.OName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OName.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OName.Location = new System.Drawing.Point(17, 192);
            this.OName.Name = "OName";
            this.OName.Size = new System.Drawing.Size(232, 24);
            this.OName.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.AnimalId);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.OName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AName);
            this.panel1.Controls.Add(this.DOBTimePicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.OContact);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(470, 38);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 274);
            this.panel1.TabIndex = 42;
            // 
            // AnimalId
            // 
            this.AnimalId.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AnimalId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnimalId.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimalId.Location = new System.Drawing.Point(229, 5);
            this.AnimalId.Name = "AnimalId";
            this.AnimalId.Size = new System.Drawing.Size(20, 24);
            this.AnimalId.TabIndex = 41;
            this.AnimalId.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(17, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Animal Name";
            // 
            // animalGridView
            // 
            this.animalGridView.AllowUserToAddRows = false;
            this.animalGridView.AllowUserToResizeColumns = false;
            this.animalGridView.AllowUserToResizeRows = false;
            this.animalGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.animalGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animalGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.animalGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.animalGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.animalGridView.Location = new System.Drawing.Point(24, 102);
            this.animalGridView.Name = "animalGridView";
            this.animalGridView.ReadOnly = true;
            this.animalGridView.RowHeadersVisible = false;
            this.animalGridView.RowHeadersWidth = 51;
            this.animalGridView.RowTemplate.Height = 25;
            this.animalGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.animalGridView.ShowEditingIcon = false;
            this.animalGridView.Size = new System.Drawing.Size(407, 320);
            this.animalGridView.TabIndex = 43;
            this.animalGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.animalGridView_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.edithobby);
            this.panel2.Location = new System.Drawing.Point(470, 315);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 147);
            this.panel2.TabIndex = 44;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(17, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(232, 94);
            this.listView1.TabIndex = 47;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // edithobby
            // 
            this.edithobby.BackColor = System.Drawing.Color.RoyalBlue;
            this.edithobby.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.edithobby.FlatAppearance.BorderSize = 0;
            this.edithobby.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edithobby.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edithobby.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.edithobby.Location = new System.Drawing.Point(61, 111);
            this.edithobby.Margin = new System.Windows.Forms.Padding(0);
            this.edithobby.Name = "edithobby";
            this.edithobby.Size = new System.Drawing.Size(141, 26);
            this.edithobby.TabIndex = 45;
            this.edithobby.Text = "EDIT ANIMAL HOBBY";
            this.edithobby.UseVisualStyleBackColor = false;
            this.edithobby.Click += new System.EventHandler(this.edithobby_Click);
            // 
            // deletebt
            // 
            this.deletebt.BackColor = System.Drawing.Color.RoyalBlue;
            this.deletebt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.deletebt.FlatAppearance.BorderSize = 0;
            this.deletebt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.deletebt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.deletebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebt.ForeColor = System.Drawing.Color.White;
            this.deletebt.Location = new System.Drawing.Point(332, 434);
            this.deletebt.Name = "deletebt";
            this.deletebt.Size = new System.Drawing.Size(99, 28);
            this.deletebt.TabIndex = 48;
            this.deletebt.Text = "DELETE";
            this.deletebt.UseVisualStyleBackColor = false;
            this.deletebt.Click += new System.EventHandler(this.deletebt_Click);
            // 
            // updatebt
            // 
            this.updatebt.BackColor = System.Drawing.Color.RoyalBlue;
            this.updatebt.FlatAppearance.BorderSize = 0;
            this.updatebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatebt.Location = new System.Drawing.Point(177, 434);
            this.updatebt.Name = "updatebt";
            this.updatebt.Size = new System.Drawing.Size(99, 28);
            this.updatebt.TabIndex = 47;
            this.updatebt.Text = "UPDATE";
            this.updatebt.UseVisualStyleBackColor = false;
            this.updatebt.Click += new System.EventHandler(this.updatebt_Click);
            // 
            // savebt
            // 
            this.savebt.BackColor = System.Drawing.Color.RoyalBlue;
            this.savebt.FlatAppearance.BorderSize = 0;
            this.savebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebt.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.savebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savebt.Location = new System.Drawing.Point(24, 435);
            this.savebt.Name = "savebt";
            this.savebt.Size = new System.Drawing.Size(99, 28);
            this.savebt.TabIndex = 46;
            this.savebt.Text = "SAVE";
            this.savebt.UseVisualStyleBackColor = false;
            this.savebt.Click += new System.EventHandler(this.savebt_Click);
            // 
            // viewbt
            // 
            this.viewbt.BackColor = System.Drawing.Color.RoyalBlue;
            this.viewbt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.viewbt.FlatAppearance.BorderSize = 0;
            this.viewbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewbt.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.viewbt.Location = new System.Drawing.Point(24, 69);
            this.viewbt.Margin = new System.Windows.Forms.Padding(0);
            this.viewbt.Name = "viewbt";
            this.viewbt.Size = new System.Drawing.Size(99, 27);
            this.viewbt.TabIndex = 45;
            this.viewbt.Text = "VIEW";
            this.viewbt.UseVisualStyleBackColor = false;
            this.viewbt.Click += new System.EventHandler(this.viewbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Console", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(709, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 35);
            this.label9.TabIndex = 50;
            this.label9.Text = "x";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // searchtb
            // 
            this.searchtb.BackColor = System.Drawing.Color.LightSteelBlue;
            this.searchtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchtb.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchtb.Location = new System.Drawing.Point(287, 68);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(145, 24);
            this.searchtb.TabIndex = 51;
            this.searchtb.TextChanged += new System.EventHandler(this.searchtb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(370, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 19);
            this.label10.TabIndex = 52;
            this.label10.Text = "Edit Hobby";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(773, 485);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deletebt);
            this.Controls.Add(this.updatebt);
            this.Controls.Add(this.savebt);
            this.Controls.Add(this.viewbt);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.animalGridView);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label7;
        private ComboBox AType;
        private TextBox AName;
        private Label label6;
        private TextBox OContact;
        private Label label5;
        private Label label4;
        private DateTimePicker DOBTimePicker;
        private Label label3;
        private Label label2;
        private TextBox OName;
        private Panel panel1;
        private DataGridView animalGridView;
        private Label label8;
        private Panel panel2;
        private Button edithobby;
        private Button deletebt;
        private Button updatebt;
        private Button savebt;
        private Button viewbt;
        private Label label1;
        private Label label9;
        private TextBox searchtb;
        private TextBox AnimalId;
        private Label label10;
        private ListView listView1;
    }
}