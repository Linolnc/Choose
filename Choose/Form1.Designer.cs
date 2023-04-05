namespace Choose
{
    partial class optionOne
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optionOne));
            this.opt = new System.Windows.Forms.Button();
            this.optiontwo = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.Label();
            this.hud = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hud)).BeginInit();
            this.SuspendLayout();
            // 
            // opt
            // 
            this.opt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.opt.Location = new System.Drawing.Point(71, 341);
            this.opt.Name = "opt";
            this.opt.Size = new System.Drawing.Size(146, 49);
            this.opt.TabIndex = 0;
            this.opt.Text = "optionOne";
            this.opt.UseVisualStyleBackColor = true;
            this.opt.Click += new System.EventHandler(this.opt_Click);
            // 
            // optiontwo
            // 
            this.optiontwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optiontwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optiontwo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.optiontwo.Location = new System.Drawing.Point(543, 341);
            this.optiontwo.Name = "optiontwo";
            this.optiontwo.Size = new System.Drawing.Size(142, 49);
            this.optiontwo.TabIndex = 1;
            this.optiontwo.Text = "optionTwo";
            this.optiontwo.UseVisualStyleBackColor = true;
            this.optiontwo.Click += new System.EventHandler(this.optiontwo_Click);
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.output.Location = new System.Drawing.Point(157, 245);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(398, 83);
            this.output.TabIndex = 2;
            this.output.Text = "output";
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hud
            // 
            this.hud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.hud.Location = new System.Drawing.Point(127, 3);
            this.hud.Name = "hud";
            this.hud.Size = new System.Drawing.Size(461, 239);
            this.hud.TabIndex = 3;
            this.hud.TabStop = false;
            // 
            // optionOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hud);
            this.Controls.Add(this.output);
            this.Controls.Add(this.optiontwo);
            this.Controls.Add(this.opt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "optionOne";
            this.Text = "Wacky Adventure. ";
            this.Load += new System.EventHandler(this.optionOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button opt;
        private System.Windows.Forms.Button optiontwo;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.PictureBox hud;
    }
}

