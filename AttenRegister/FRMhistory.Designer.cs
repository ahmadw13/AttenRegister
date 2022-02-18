namespace AttenRegister
{
    partial class FRMhistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMhistory));
            this.dgvhistory = new System.Windows.Forms.DataGridView();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnback = new System.Windows.Forms.Button();
            this.datesearch = new System.Windows.Forms.DateTimePicker();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btndateprint = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvhistory
            // 
            this.dgvhistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvhistory.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvhistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvhistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhistory.Location = new System.Drawing.Point(12, 86);
            this.dgvhistory.Name = "dgvhistory";
            this.dgvhistory.ReadOnly = true;
            this.dgvhistory.RowHeadersWidth = 51;
            this.dgvhistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhistory.Size = new System.Drawing.Size(704, 488);
            this.dgvhistory.TabIndex = 0;
            this.dgvhistory.Click += new System.EventHandler(this.dgvhistory_Click);
            // 
            // picPreview
            // 
            this.picPreview.Location = new System.Drawing.Point(722, 86);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(250, 239);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 1;
            this.picPreview.TabStop = false;
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 12);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(157, 36);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // datesearch
            // 
            this.datesearch.CustomFormat = "";
            this.datesearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datesearch.Location = new System.Drawing.Point(317, 12);
            this.datesearch.Name = "datesearch";
            this.datesearch.Size = new System.Drawing.Size(253, 30);
            this.datesearch.TabIndex = 3;
            this.datesearch.ValueChanged += new System.EventHandler(this.datesearch_ValueChanged);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(722, 535);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(250, 39);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnprint
            // 
            this.btnprint.Location = new System.Drawing.Point(722, 490);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(250, 39);
            this.btnprint.TabIndex = 5;
            this.btnprint.Text = "Print All";
            this.btnprint.UseVisualStyleBackColor = true;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btndateprint
            // 
            this.btndateprint.Location = new System.Drawing.Point(722, 445);
            this.btndateprint.Name = "btndateprint";
            this.btndateprint.Size = new System.Drawing.Size(250, 39);
            this.btndateprint.TabIndex = 6;
            this.btndateprint.Text = "Print By Date";
            this.btndateprint.UseVisualStyleBackColor = true;
            this.btndateprint.Click += new System.EventHandler(this.btndateprint_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "History deletion options";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FRMhistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(984, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btndateprint);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.datesearch);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.picPreview);
            this.Controls.Add(this.dgvhistory);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FRMhistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "History";
            this.Load += new System.EventHandler(this.FRMhistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvhistory;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.DateTimePicker datesearch;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btndateprint;
        private System.Windows.Forms.Button button1;
    }
}