namespace Assignment3OO
{
    partial class FormVendingMachine
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
            this.lblInsructions = new System.Windows.Forms.Label();
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.rbHotChocolate = new System.Windows.Forms.RadioButton();
            this.rbTea = new System.Windows.Forms.RadioButton();
            this.pbTea = new System.Windows.Forms.PictureBox();
            this.pbHotChocolate = new System.Windows.Forms.PictureBox();
            this.pbCoffee = new System.Windows.Forms.PictureBox();
            this.lblAskedPrep = new System.Windows.Forms.Label();
            this.lblEnjoy = new System.Windows.Forms.Label();
            this.lblPreparation = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblDrinkSelected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotChocolate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInsructions
            // 
            this.lblInsructions.AutoSize = true;
            this.lblInsructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsructions.Location = new System.Drawing.Point(65, 9);
            this.lblInsructions.Name = "lblInsructions";
            this.lblInsructions.Size = new System.Drawing.Size(428, 38);
            this.lblInsructions.TabIndex = 0;
            this.lblInsructions.Text = "Please choose a hot drink:";
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCoffee.Location = new System.Drawing.Point(72, 224);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(120, 36);
            this.rbCoffee.TabIndex = 4;
            this.rbCoffee.Text = "Coffee";
            this.rbCoffee.UseVisualStyleBackColor = true;
            this.rbCoffee.CheckedChanged += new System.EventHandler(this.rbCoffee_CheckedChanged);
            // 
            // rbHotChocolate
            // 
            this.rbHotChocolate.AutoSize = true;
            this.rbHotChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHotChocolate.Location = new System.Drawing.Point(368, 224);
            this.rbHotChocolate.Name = "rbHotChocolate";
            this.rbHotChocolate.Size = new System.Drawing.Size(216, 36);
            this.rbHotChocolate.TabIndex = 5;
            this.rbHotChocolate.Text = "Hot Chocolate";
            this.rbHotChocolate.UseVisualStyleBackColor = true;
            this.rbHotChocolate.CheckedChanged += new System.EventHandler(this.rbHotChocolate_CheckedChanged);
            // 
            // rbTea
            // 
            this.rbTea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTea.AutoSize = true;
            this.rbTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTea.Location = new System.Drawing.Point(655, 225);
            this.rbTea.Name = "rbTea";
            this.rbTea.Size = new System.Drawing.Size(85, 36);
            this.rbTea.TabIndex = 6;
            this.rbTea.Text = "Tea";
            this.rbTea.UseVisualStyleBackColor = true;
            this.rbTea.Click += new System.EventHandler(this.rbTea_Click);
            // 
            // pbTea
            // 
            this.pbTea.Image = global::Assignment3OO.Properties.Resources.tea;
            this.pbTea.Location = new System.Drawing.Point(655, 65);
            this.pbTea.Name = "pbTea";
            this.pbTea.Size = new System.Drawing.Size(170, 154);
            this.pbTea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTea.TabIndex = 3;
            this.pbTea.TabStop = false;
            // 
            // pbHotChocolate
            // 
            this.pbHotChocolate.Image = global::Assignment3OO.Properties.Resources.hot_chocolate;
            this.pbHotChocolate.Location = new System.Drawing.Point(368, 65);
            this.pbHotChocolate.Name = "pbHotChocolate";
            this.pbHotChocolate.Size = new System.Drawing.Size(143, 153);
            this.pbHotChocolate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHotChocolate.TabIndex = 2;
            this.pbHotChocolate.TabStop = false;
            // 
            // pbCoffee
            // 
            this.pbCoffee.Image = global::Assignment3OO.Properties.Resources.coffee;
            this.pbCoffee.Location = new System.Drawing.Point(72, 60);
            this.pbCoffee.Name = "pbCoffee";
            this.pbCoffee.Size = new System.Drawing.Size(143, 158);
            this.pbCoffee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoffee.TabIndex = 1;
            this.pbCoffee.TabStop = false;
            // 
            // lblAskedPrep
            // 
            this.lblAskedPrep.BackColor = System.Drawing.Color.White;
            this.lblAskedPrep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAskedPrep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAskedPrep.Location = new System.Drawing.Point(66, 506);
            this.lblAskedPrep.Name = "lblAskedPrep";
            this.lblAskedPrep.Size = new System.Drawing.Size(775, 89);
            this.lblAskedPrep.TabIndex = 7;
            // 
            // lblEnjoy
            // 
            this.lblEnjoy.AutoSize = true;
            this.lblEnjoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnjoy.Location = new System.Drawing.Point(64, 403);
            this.lblEnjoy.Name = "lblEnjoy";
            this.lblEnjoy.Size = new System.Drawing.Size(303, 44);
            this.lblEnjoy.TabIndex = 8;
            this.lblEnjoy.Text = "Enjoy your drink:";
            // 
            // lblPreparation
            // 
            this.lblPreparation.BackColor = System.Drawing.Color.White;
            this.lblPreparation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPreparation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblPreparation.Location = new System.Drawing.Point(66, 447);
            this.lblPreparation.Name = "lblPreparation";
            this.lblPreparation.Size = new System.Drawing.Size(775, 48);
            this.lblPreparation.TabIndex = 10;
            this.lblPreparation.Text = "Preparing:";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuy.Enabled = false;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnBuy.Location = new System.Drawing.Point(72, 284);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(268, 64);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Pay and order";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.BackColor = System.Drawing.Color.White;
            this.lblSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSelected.Location = new System.Drawing.Point(399, 284);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(214, 45);
            this.lblSelected.TabIndex = 13;
            this.lblSelected.Text = "You selected:";
            // 
            // lblDrinkSelected
            // 
            this.lblDrinkSelected.BackColor = System.Drawing.Color.White;
            this.lblDrinkSelected.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDrinkSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblDrinkSelected.Location = new System.Drawing.Point(399, 343);
            this.lblDrinkSelected.Name = "lblDrinkSelected";
            this.lblDrinkSelected.Size = new System.Drawing.Size(426, 45);
            this.lblDrinkSelected.TabIndex = 14;
            // 
            // FormVendingMachine
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(903, 645);
            this.Controls.Add(this.lblDrinkSelected);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.lblPreparation);
            this.Controls.Add(this.lblEnjoy);
            this.Controls.Add(this.lblAskedPrep);
            this.Controls.Add(this.rbTea);
            this.Controls.Add(this.rbHotChocolate);
            this.Controls.Add(this.rbCoffee);
            this.Controls.Add(this.pbTea);
            this.Controls.Add(this.pbHotChocolate);
            this.Controls.Add(this.pbCoffee);
            this.Controls.Add(this.lblInsructions);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FormVendingMachine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pbTea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotChocolate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInsructions;
        private System.Windows.Forms.PictureBox pbCoffee;
        private System.Windows.Forms.PictureBox pbHotChocolate;
        private System.Windows.Forms.PictureBox pbTea;
        private System.Windows.Forms.RadioButton rbCoffee;
        private System.Windows.Forms.RadioButton rbHotChocolate;
        private System.Windows.Forms.RadioButton rbTea;
        private System.Windows.Forms.Label lblAskedPrep;
        private System.Windows.Forms.Label lblEnjoy;
        private System.Windows.Forms.Label lblPreparation;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblDrinkSelected;
    }
}

