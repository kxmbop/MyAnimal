namespace MyAnimal
{
    partial class AnimalHobbies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalHobbies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.animalHobbiesDataGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addbt = new System.Windows.Forms.Button();
            this.delbt = new System.Windows.Forms.Button();
            this.savehubbt = new System.Windows.Forms.Button();
            this.hobbyGridView = new System.Windows.Forms.DataGridView();
            this.AnimalId2 = new System.Windows.Forms.TextBox();
            this.HobbyId = new System.Windows.Forms.TextBox();
            this.hobbyId2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.animalHobbiesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hobbyGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Name = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Name = "label7";
            // 
            // animalHobbiesDataGrid
            // 
            this.animalHobbiesDataGrid.AllowUserToAddRows = false;
            this.animalHobbiesDataGrid.AllowUserToResizeColumns = false;
            this.animalHobbiesDataGrid.AllowUserToResizeRows = false;
            this.animalHobbiesDataGrid.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.animalHobbiesDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.animalHobbiesDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.animalHobbiesDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.animalHobbiesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalHobbiesDataGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.animalHobbiesDataGrid.DefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.animalHobbiesDataGrid, "animalHobbiesDataGrid");
            this.animalHobbiesDataGrid.Name = "animalHobbiesDataGrid";
            this.animalHobbiesDataGrid.RowHeadersVisible = false;
            this.animalHobbiesDataGrid.RowTemplate.Height = 25;
            this.animalHobbiesDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.animalHobbiesDataGrid_CellClick);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addbt
            // 
            this.addbt.BackColor = System.Drawing.Color.RoyalBlue;
            this.addbt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addbt.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.addbt, "addbt");
            this.addbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addbt.Name = "addbt";
            this.addbt.UseVisualStyleBackColor = false;
            this.addbt.Click += new System.EventHandler(this.addbt_Click);
            // 
            // delbt
            // 
            this.delbt.BackColor = System.Drawing.Color.RoyalBlue;
            this.delbt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delbt.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.delbt, "delbt");
            this.delbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delbt.Name = "delbt";
            this.delbt.UseVisualStyleBackColor = false;
            this.delbt.Click += new System.EventHandler(this.delbt_Click);
            // 
            // savehubbt
            // 
            this.savehubbt.BackColor = System.Drawing.Color.RoyalBlue;
            this.savehubbt.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.savehubbt, "savehubbt");
            this.savehubbt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.savehubbt.Name = "savehubbt";
            this.savehubbt.UseVisualStyleBackColor = false;
            this.savehubbt.Click += new System.EventHandler(this.savehubbt_Click);
            // 
            // hobbyGridView
            // 
            this.hobbyGridView.AllowUserToAddRows = false;
            this.hobbyGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.hobbyGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hobbyGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.hobbyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hobbyGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.hobbyGridView.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.hobbyGridView, "hobbyGridView");
            this.hobbyGridView.Name = "hobbyGridView";
            this.hobbyGridView.RowHeadersVisible = false;
            this.hobbyGridView.RowTemplate.Height = 25;
            this.hobbyGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hobbyGridView_CellClick_1);
            this.hobbyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.hobbyGridView_CellContentClick_1);
            // 
            // AnimalId2
            // 
            this.AnimalId2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.AnimalId2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.AnimalId2, "AnimalId2");
            this.AnimalId2.Name = "AnimalId2";
            // 
            // HobbyId
            // 
            this.HobbyId.BackColor = System.Drawing.Color.LightSteelBlue;
            this.HobbyId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.HobbyId, "HobbyId");
            this.HobbyId.Name = "HobbyId";
            // 
            // hobbyId2
            // 
            this.hobbyId2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.hobbyId2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.hobbyId2, "hobbyId2");
            this.hobbyId2.Name = "hobbyId2";
            // 
            // AnimalHobbies
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.savehubbt);
            this.Controls.Add(this.delbt);
            this.Controls.Add(this.addbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.animalHobbiesDataGrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AnimalId2);
            this.Controls.Add(this.hobbyGridView);
            this.Controls.Add(this.HobbyId);
            this.Controls.Add(this.hobbyId2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimalHobbies";
            ((System.ComponentModel.ISupportInitialize)(this.animalHobbiesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hobbyGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label7;
        private DataGridView animalHobbiesDataGrid;
        private Label label2;
        private Label label1;
        private Button addbt;
        private Button delbt;
        private Button savehubbt;
        private DataGridView hobbyGridView;
        public TextBox AnimalId2;
        public TextBox HobbyId;
        public TextBox hobbyId2;
    }
}