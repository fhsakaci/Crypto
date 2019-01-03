/*
 * Created by SharpDevelop.
 * User: Fatih
 * Date: 13.12.2018
 * Time: 19:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TwineProjectCrypto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Key;
		private System.Windows.Forms.TextBox PlainText;
		private System.Windows.Forms.Button Crypto;
		private System.Windows.Forms.Label CryptoText;
		private System.Windows.Forms.Label plaint;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Key = new System.Windows.Forms.TextBox();
			this.PlainText = new System.Windows.Forms.TextBox();
			this.Crypto = new System.Windows.Forms.Button();
			this.CryptoText = new System.Windows.Forms.Label();
			this.plaint = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Control;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.Key);
			this.panel1.Controls.Add(this.PlainText);
			this.panel1.Controls.Add(this.Crypto);
			this.panel1.Location = new System.Drawing.Point(325, 187);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(330, 145);
			this.panel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(67, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(191, 29);
			this.label5.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(67, 65);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(75, 19);
			this.label2.TabIndex = 3;
			this.label2.Text = "Plain Text:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(67, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Key:";
			// 
			// Key
			// 
			this.Key.Location = new System.Drawing.Point(146, 40);
			this.Key.Margin = new System.Windows.Forms.Padding(2);
			this.Key.Name = "Key";
			this.Key.Size = new System.Drawing.Size(146, 20);
			this.Key.TabIndex = 2;
			// 
			// PlainText
			// 
			this.PlainText.Location = new System.Drawing.Point(146, 64);
			this.PlainText.Margin = new System.Windows.Forms.Padding(2);
			this.PlainText.Multiline = true;
			this.PlainText.Name = "PlainText";
			this.PlainText.Size = new System.Drawing.Size(146, 46);
			this.PlainText.TabIndex = 1;
			// 
			// Crypto
			// 
			this.Crypto.Location = new System.Drawing.Point(175, 113);
			this.Crypto.Margin = new System.Windows.Forms.Padding(2);
			this.Crypto.Name = "Crypto";
			this.Crypto.Size = new System.Drawing.Size(117, 23);
			this.Crypto.TabIndex = 0;
			this.Crypto.Text = "Encrypt-Decrypt";
			this.Crypto.UseVisualStyleBackColor = true;
			this.Crypto.Click += new System.EventHandler(this.CryptoClick);
			// 
			// CryptoText
			// 
			this.CryptoText.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.CryptoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CryptoText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.CryptoText.Location = new System.Drawing.Point(51, 9);
			this.CryptoText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.CryptoText.Name = "CryptoText";
			this.CryptoText.Size = new System.Drawing.Size(300, 138);
			this.CryptoText.TabIndex = 1;
			// 
			// plaint
			// 
			this.plaint.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.plaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.plaint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.plaint.Location = new System.Drawing.Point(355, 9);
			this.plaint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.plaint.Name = "plaint";
			this.plaint.Size = new System.Drawing.Size(300, 138);
			this.plaint.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(51, 302);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(212, 19);
			this.label4.TabIndex = 4;
			this.label4.Text = "Furkan Hasan SAKACI";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(163, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(65, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Crypto";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(455, 151);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(89, 23);
			this.label7.TabIndex = 6;
			this.label7.Text = "Decrypto";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 353);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.plaint);
			this.Controls.Add(this.CryptoText);
			this.Controls.Add(this.panel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "TwineProjectCrypto";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
