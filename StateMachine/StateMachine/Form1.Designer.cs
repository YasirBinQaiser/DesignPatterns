namespace StateMachine
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_BlockSignal = new System.Windows.Forms.CheckBox();
            this.btn_Power = new System.Windows.Forms.Button();
            this.tvImages = new System.Windows.Forms.ImageList(this.components);
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_PowerOff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // chk_BlockSignal
            // 
            this.chk_BlockSignal.AutoSize = true;
            this.chk_BlockSignal.Location = new System.Drawing.Point(12, 179);
            this.chk_BlockSignal.Name = "chk_BlockSignal";
            this.chk_BlockSignal.Size = new System.Drawing.Size(85, 17);
            this.chk_BlockSignal.TabIndex = 1;
            this.chk_BlockSignal.Text = "Block Signal";
            this.chk_BlockSignal.UseVisualStyleBackColor = true;
            // 
            // btn_Power
            // 
            this.btn_Power.Image = ((System.Drawing.Image)(resources.GetObject("btn_Power.Image")));
            this.btn_Power.Location = new System.Drawing.Point(3, 16);
            this.btn_Power.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Power.Name = "btn_Power";
            this.btn_Power.Size = new System.Drawing.Size(42, 42);
            this.btn_Power.TabIndex = 2;
            this.btn_Power.UseVisualStyleBackColor = true;
            this.btn_Power.Click += new System.EventHandler(this.btn_Power_Click);
            // 
            // tvImages
            // 
            this.tvImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tvImages.ImageStream")));
            this.tvImages.TransparentColor = System.Drawing.Color.Transparent;
            this.tvImages.Images.SetKeyName(0, "Off");
            this.tvImages.Images.SetKeyName(1, "On");
            this.tvImages.Images.SetKeyName(2, "Sleep");
            // 
            // lbl_Status
            // 
            this.lbl_Status.Location = new System.Drawing.Point(12, 199);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(271, 23);
            this.lbl_Status.TabIndex = 3;
            // 
            // btn_PowerOff
            // 
            this.btn_PowerOff.Image = ((System.Drawing.Image)(resources.GetObject("btn_PowerOff.Image")));
            this.btn_PowerOff.Location = new System.Drawing.Point(15, 157);
            this.btn_PowerOff.Name = "btn_PowerOff";
            this.btn_PowerOff.Size = new System.Drawing.Size(16, 16);
            this.btn_PowerOff.TabIndex = 4;
            this.btn_PowerOff.UseVisualStyleBackColor = true;
            this.btn_PowerOff.Click += new System.EventHandler(this.btn_PowerOff_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.btn_Power);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(280, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(47, 152);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 234);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_PowerOff);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.chk_BlockSignal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "State Machine - TV / REmote";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_BlockSignal;
        private System.Windows.Forms.Button btn_Power;
        private System.Windows.Forms.ImageList tvImages;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_PowerOff;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

