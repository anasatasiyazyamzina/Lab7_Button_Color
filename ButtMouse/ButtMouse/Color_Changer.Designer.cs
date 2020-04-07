namespace Color_Picker
{
    partial class Color_Changer
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
            this.tb_green = new System.Windows.Forms.TrackBar();
            this.tb_blue = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.tb_red = new System.Windows.Forms.TrackBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.l0_red = new System.Windows.Forms.Label();
            this.l0_green = new System.Windows.Forms.Label();
            this.l0_blue = new System.Windows.Forms.Label();
            this.l255_red = new System.Windows.Forms.Label();
            this.l255_green = new System.Windows.Forms.Label();
            this.l255_blue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_green
            // 
            this.tb_green.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_green.Location = new System.Drawing.Point(186, 67);
            this.tb_green.Maximum = 255;
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(173, 45);
            this.tb_green.TabIndex = 1;
            this.tb_green.TickFrequency = 20;
            this.tb_green.Value = 125;
            this.tb_green.Scroll += new System.EventHandler(this.color_scroll);
            // 
            // tb_blue
            // 
            this.tb_blue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_blue.Location = new System.Drawing.Point(186, 118);
            this.tb_blue.Maximum = 255;
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(173, 45);
            this.tb_blue.TabIndex = 1;
            this.tb_blue.Tag = "";
            this.tb_blue.TickFrequency = 20;
            this.tb_blue.Value = 125;
            this.tb_blue.Scroll += new System.EventHandler(this.color_scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // lbl_red
            // 
            this.lbl_red.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_red.AutoSize = true;
            this.lbl_red.Location = new System.Drawing.Point(152, 28);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(30, 13);
            this.lbl_red.TabIndex = 5;
            this.lbl_red.Text = "Red:";
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPanel.Location = new System.Drawing.Point(12, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(134, 151);
            this.ColorPanel.TabIndex = 6;
            // 
            // lbl_green
            // 
            this.lbl_green.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_green.AutoSize = true;
            this.lbl_green.Location = new System.Drawing.Point(152, 76);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(39, 13);
            this.lbl_green.TabIndex = 7;
            this.lbl_green.Text = "Green:";
            // 
            // lbl_blue
            // 
            this.lbl_blue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Location = new System.Drawing.Point(152, 129);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(31, 13);
            this.lbl_blue.TabIndex = 8;
            this.lbl_blue.Text = "Blue:";
            // 
            // tb_red
            // 
            this.tb_red.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_red.Location = new System.Drawing.Point(188, 16);
            this.tb_red.Maximum = 255;
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(173, 45);
            this.tb_red.TabIndex = 9;
            this.tb_red.TickFrequency = 20;
            this.tb_red.Value = 125;
            this.tb_red.Scroll += new System.EventHandler(this.color_scroll);
            // 
            // l0_red
            // 
            this.l0_red.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l0_red.AutoSize = true;
            this.l0_red.Location = new System.Drawing.Point(194, 48);
            this.l0_red.Name = "l0_red";
            this.l0_red.Size = new System.Drawing.Size(13, 13);
            this.l0_red.TabIndex = 10;
            this.l0_red.Text = "0";
            // 
            // l0_green
            // 
            this.l0_green.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l0_green.AutoSize = true;
            this.l0_green.Location = new System.Drawing.Point(194, 99);
            this.l0_green.Name = "l0_green";
            this.l0_green.Size = new System.Drawing.Size(13, 13);
            this.l0_green.TabIndex = 11;
            this.l0_green.Text = "0";
            // 
            // l0_blue
            // 
            this.l0_blue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l0_blue.AutoSize = true;
            this.l0_blue.Location = new System.Drawing.Point(194, 149);
            this.l0_blue.Name = "l0_blue";
            this.l0_blue.Size = new System.Drawing.Size(13, 13);
            this.l0_blue.TabIndex = 12;
            this.l0_blue.Text = "0";
            // 
            // l255_red
            // 
            this.l255_red.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l255_red.AutoSize = true;
            this.l255_red.Location = new System.Drawing.Point(336, 48);
            this.l255_red.Name = "l255_red";
            this.l255_red.Size = new System.Drawing.Size(25, 13);
            this.l255_red.TabIndex = 13;
            this.l255_red.Text = "255";
            // 
            // l255_green
            // 
            this.l255_green.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l255_green.AutoSize = true;
            this.l255_green.Location = new System.Drawing.Point(334, 99);
            this.l255_green.Name = "l255_green";
            this.l255_green.Size = new System.Drawing.Size(25, 13);
            this.l255_green.TabIndex = 14;
            this.l255_green.Text = "255";
            // 
            // l255_blue
            // 
            this.l255_blue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.l255_blue.AutoSize = true;
            this.l255_blue.Location = new System.Drawing.Point(334, 150);
            this.l255_blue.Name = "l255_blue";
            this.l255_blue.Size = new System.Drawing.Size(25, 13);
            this.l255_blue.TabIndex = 15;
            this.l255_blue.Text = "255";
            // 
            // Color_Changer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 171);
            this.Controls.Add(this.l255_blue);
            this.Controls.Add(this.l255_green);
            this.Controls.Add(this.l255_red);
            this.Controls.Add(this.l0_blue);
            this.Controls.Add(this.l0_green);
            this.Controls.Add(this.l0_red);
            this.Controls.Add(this.lbl_red);
            this.Controls.Add(this.tb_red);
            this.Controls.Add(this.lbl_blue);
            this.Controls.Add(this.lbl_green);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_blue);
            this.Controls.Add(this.tb_green);
            this.MinimumSize = new System.Drawing.Size(380, 210);
            this.Name = "Color_Changer";
            this.Text = "Color Picker";
            this.Load += new System.EventHandler(this.Color_Changer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb_green;
        private System.Windows.Forms.TrackBar tb_blue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.TrackBar tb_red;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label l0_red;
        private System.Windows.Forms.Label l0_green;
        private System.Windows.Forms.Label l0_blue;
        private System.Windows.Forms.Label l255_red;
        private System.Windows.Forms.Label l255_green;
        private System.Windows.Forms.Label l255_blue;
    }
}