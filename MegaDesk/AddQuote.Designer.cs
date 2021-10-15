
namespace MegaDesk
{
    partial class AddQuote
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
            this.label1 = new System.Windows.Forms.Label();
            this.addQuote_Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numDeskDepth = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.comShippingType = new System.Windows.Forms.ComboBox();
            this.addQuote_Save = new System.Windows.Forms.Button();
            this.addQuote_Cancel = new System.Windows.Forms.Button();
            this.numDeskWidth = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numNumberOfDrawers = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.errorMessageWidth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numDeskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeskWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Quote";
            // 
            // addQuote_Back
            // 
            this.addQuote_Back.Location = new System.Drawing.Point(408, 533);
            this.addQuote_Back.Name = "addQuote_Back";
            this.addQuote_Back.Size = new System.Drawing.Size(221, 37);
            this.addQuote_Back.TabIndex = 1;
            this.addQuote_Back.Text = "Back to Main Menu";
            this.addQuote_Back.UseVisualStyleBackColor = true;
            this.addQuote_Back.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(371, 130);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(415, 31);
            this.CustomerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth";
            // 
            // numDeskDepth
            // 
            this.numDeskDepth.ForeColor = System.Drawing.Color.Black;
            this.numDeskDepth.Location = new System.Drawing.Point(259, 251);
            this.numDeskDepth.Name = "numDeskDepth";
            this.numDeskDepth.Size = new System.Drawing.Size(172, 31);
            this.numDeskDepth.TabIndex = 5;
            this.numDeskDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numDeskDepth_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Shipping";
            // 
            // comShippingType
            // 
            this.comShippingType.FormattingEnabled = true;
            this.comShippingType.Location = new System.Drawing.Point(697, 253);
            this.comShippingType.Name = "comShippingType";
            this.comShippingType.Size = new System.Drawing.Size(169, 33);
            this.comShippingType.TabIndex = 7;
            // 
            // addQuote_Save
            // 
            this.addQuote_Save.Location = new System.Drawing.Point(523, 422);
            this.addQuote_Save.Name = "addQuote_Save";
            this.addQuote_Save.Size = new System.Drawing.Size(244, 49);
            this.addQuote_Save.TabIndex = 8;
            this.addQuote_Save.Text = "Save";
            this.addQuote_Save.UseVisualStyleBackColor = true;
            this.addQuote_Save.Click += new System.EventHandler(this.addQuote_Save_Click);
            // 
            // addQuote_Cancel
            // 
            this.addQuote_Cancel.Location = new System.Drawing.Point(259, 422);
            this.addQuote_Cancel.Name = "addQuote_Cancel";
            this.addQuote_Cancel.Size = new System.Drawing.Size(244, 49);
            this.addQuote_Cancel.TabIndex = 9;
            this.addQuote_Cancel.Text = "Cancel";
            this.addQuote_Cancel.UseVisualStyleBackColor = true;
            this.addQuote_Cancel.Click += new System.EventHandler(this.button3_Click);
            // 
            // numDeskWidth
            // 
            this.numDeskWidth.Location = new System.Drawing.Point(259, 302);
            this.numDeskWidth.Name = "numDeskWidth";
            this.numDeskWidth.Size = new System.Drawing.Size(172, 31);
            this.numDeskWidth.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Width";
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.FormattingEnabled = true;
            this.comSurfaceMaterial.Location = new System.Drawing.Point(697, 300);
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            this.comSurfaceMaterial.Size = new System.Drawing.Size(169, 33);
            this.comSurfaceMaterial.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Surface Material";
            // 
            // numNumberOfDrawers
            // 
            this.numNumberOfDrawers.Location = new System.Drawing.Point(694, 206);
            this.numNumberOfDrawers.Name = "numNumberOfDrawers";
            this.numNumberOfDrawers.Size = new System.Drawing.Size(172, 31);
            this.numNumberOfDrawers.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Number of Drawers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Desk Size:";
            // 
            // errorMessageWidth
            // 
            this.errorMessageWidth.AutoSize = true;
            this.errorMessageWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageWidth.Location = new System.Drawing.Point(184, 340);
            this.errorMessageWidth.Name = "errorMessageWidth";
            this.errorMessageWidth.Size = new System.Drawing.Size(0, 24);
            this.errorMessageWidth.TabIndex = 17;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 652);
            this.Controls.Add(this.errorMessageWidth);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numNumberOfDrawers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comSurfaceMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numDeskWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addQuote_Cancel);
            this.Controls.Add(this.addQuote_Save);
            this.Controls.Add(this.comShippingType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numDeskDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addQuote_Back);
            this.Controls.Add(this.label1);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.numDeskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDeskWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addQuote_Back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDeskDepth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comShippingType;
        private System.Windows.Forms.Button addQuote_Save;
        private System.Windows.Forms.Button addQuote_Cancel;
        private System.Windows.Forms.NumericUpDown numDeskWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comSurfaceMaterial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numNumberOfDrawers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label errorMessageWidth;
    }
}