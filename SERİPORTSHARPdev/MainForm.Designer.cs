/*
 * Created by SharpDevelop.
 * User: C M Y
 * Date: 2.12.2024
 * Time: 12:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace seriportodev
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnac;
		private System.Windows.Forms.Button btnkapa;
		private System.Windows.Forms.TextBox textcom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBaudrate;
		private System.Windows.Forms.Label baudrate;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textdatabit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonsaatgönder;
		private System.Windows.Forms.TextBox textADCverisi;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnyazıgonder;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textbaşlangıç;
		private System.Windows.Forms.Button btnbirincisatirisil;
		private System.Windows.Forms.TextBox textMCdengelen;
		private System.Windows.Forms.Label LCD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textgelenveri;
		private System.Windows.Forms.TextBox textgönderilecekveri;
		
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
			this.components = new System.ComponentModel.Container();
			this.btnac = new System.Windows.Forms.Button();
			this.btnkapa = new System.Windows.Forms.Button();
			this.textcom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBaudrate = new System.Windows.Forms.TextBox();
			this.baudrate = new System.Windows.Forms.Label();
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.textdatabit = new System.Windows.Forms.TextBox();
			this.textgönderilecekveri = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonsaatgönder = new System.Windows.Forms.Button();
			this.textADCverisi = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnyazıgonder = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textbaşlangıç = new System.Windows.Forms.TextBox();
			this.btnbirincisatirisil = new System.Windows.Forms.Button();
			this.textMCdengelen = new System.Windows.Forms.TextBox();
			this.LCD = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textgelenveri = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnac
			// 
			this.btnac.Location = new System.Drawing.Point(427, 62);
			this.btnac.Name = "btnac";
			this.btnac.Size = new System.Drawing.Size(75, 23);
			this.btnac.TabIndex = 0;
			this.btnac.Text = "AÇ";
			this.btnac.UseVisualStyleBackColor = true;
			this.btnac.Click += new System.EventHandler(this.BtnacClick);
			// 
			// btnkapa
			// 
			this.btnkapa.Location = new System.Drawing.Point(427, 103);
			this.btnkapa.Name = "btnkapa";
			this.btnkapa.Size = new System.Drawing.Size(75, 23);
			this.btnkapa.TabIndex = 1;
			this.btnkapa.Text = "KAPAT";
			this.btnkapa.UseVisualStyleBackColor = true;
			this.btnkapa.Click += new System.EventHandler(this.BtnkapaClick);
			// 
			// textcom
			// 
			this.textcom.Location = new System.Drawing.Point(139, 62);
			this.textcom.Name = "textcom";
			this.textcom.Size = new System.Drawing.Size(100, 22);
			this.textcom.TabIndex = 2;
			this.textcom.Text = "COM9";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "COM NO";
			// 
			// textBaudrate
			// 
			this.textBaudrate.Location = new System.Drawing.Point(139, 103);
			this.textBaudrate.Name = "textBaudrate";
			this.textBaudrate.Size = new System.Drawing.Size(100, 22);
			this.textBaudrate.TabIndex = 4;
			this.textBaudrate.Text = "115200";
			// 
			// baudrate
			// 
			this.baudrate.Location = new System.Drawing.Point(38, 102);
			this.baudrate.Name = "baudrate";
			this.baudrate.Size = new System.Drawing.Size(100, 23);
			this.baudrate.TabIndex = 5;
			this.baudrate.Text = "BAUDRATE";
			// 
			// serialPort1
			// 
			this.serialPort1.BaudRate = 115200;
			this.serialPort1.PortName = "COM9";
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1DataReceived);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(38, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 6;
			this.label2.Text = "databits";
			// 
			// textdatabit
			// 
			this.textdatabit.Location = new System.Drawing.Point(139, 142);
			this.textdatabit.Name = "textdatabit";
			this.textdatabit.Size = new System.Drawing.Size(100, 22);
			this.textdatabit.TabIndex = 7;
			this.textdatabit.Text = "8";
			// 
			// textgönderilecekveri
			// 
			this.textgönderilecekveri.Location = new System.Drawing.Point(174, 200);
			this.textgönderilecekveri.Multiline = true;
			this.textgönderilecekveri.Name = "textgönderilecekveri";
			this.textgönderilecekveri.Size = new System.Drawing.Size(230, 52);
			this.textgönderilecekveri.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(38, 200);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(139, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "GOND.VERİ";
			// 
			// buttonsaatgönder
			// 
			this.buttonsaatgönder.Location = new System.Drawing.Point(441, 366);
			this.buttonsaatgönder.Name = "buttonsaatgönder";
			this.buttonsaatgönder.Size = new System.Drawing.Size(95, 53);
			this.buttonsaatgönder.TabIndex = 10;
			this.buttonsaatgönder.Text = "mcye gönder";
			this.buttonsaatgönder.UseVisualStyleBackColor = true;
			this.buttonsaatgönder.Click += new System.EventHandler(this.ButtonsaatgönderClick);
			// 
			// textADCverisi
			// 
			this.textADCverisi.Location = new System.Drawing.Point(155, 327);
			this.textADCverisi.Multiline = true;
			this.textADCverisi.Name = "textADCverisi";
			this.textADCverisi.Size = new System.Drawing.Size(230, 36);
			this.textADCverisi.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(38, 330);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 12;
			this.label4.Text = "ADC VERİSİ";
			// 
			// btnyazıgonder
			// 
			this.btnyazıgonder.Location = new System.Drawing.Point(450, 190);
			this.btnyazıgonder.Name = "btnyazıgonder";
			this.btnyazıgonder.Size = new System.Drawing.Size(86, 43);
			this.btnyazıgonder.TabIndex = 13;
			this.btnyazıgonder.Text = "Yazı Gönder";
			this.btnyazıgonder.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(42, 380);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 39);
			this.label5.TabIndex = 14;
			this.label5.Text = "baslangıc";
			// 
			// textbaşlangıç
			// 
			this.textbaşlangıç.Location = new System.Drawing.Point(155, 380);
			this.textbaşlangıç.Name = "textbaşlangıç";
			this.textbaşlangıç.Size = new System.Drawing.Size(230, 22);
			this.textbaşlangıç.TabIndex = 15;
			// 
			// btnbirincisatirisil
			// 
			this.btnbirincisatirisil.Location = new System.Drawing.Point(427, 265);
			this.btnbirincisatirisil.Name = "btnbirincisatirisil";
			this.btnbirincisatirisil.Size = new System.Drawing.Size(95, 47);
			this.btnbirincisatirisil.TabIndex = 16;
			this.btnbirincisatirisil.Text = "1. satırı sil";
			this.btnbirincisatirisil.UseVisualStyleBackColor = true;
			// 
			// textMCdengelen
			// 
			this.textMCdengelen.Location = new System.Drawing.Point(155, 427);
			this.textMCdengelen.Name = "textMCdengelen";
			this.textMCdengelen.Size = new System.Drawing.Size(230, 22);
			this.textMCdengelen.TabIndex = 17;
			// 
			// LCD
			// 
			this.LCD.Location = new System.Drawing.Point(42, 423);
			this.LCD.Name = "LCD";
			this.LCD.Size = new System.Drawing.Size(100, 23);
			this.LCD.TabIndex = 18;
			this.LCD.Text = "LCD";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(50, 277);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 33);
			this.label6.TabIndex = 19;
			this.label6.Text = "gelen veri";
			// 
			// textgelenveri
			// 
			this.textgelenveri.Location = new System.Drawing.Point(174, 277);
			this.textgelenveri.Name = "textgelenveri";
			this.textgelenveri.Size = new System.Drawing.Size(211, 22);
			this.textgelenveri.TabIndex = 20;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(587, 482);
			this.Controls.Add(this.textgelenveri);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.LCD);
			this.Controls.Add(this.textMCdengelen);
			this.Controls.Add(this.btnbirincisatirisil);
			this.Controls.Add(this.textbaşlangıç);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnyazıgonder);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textADCverisi);
			this.Controls.Add(this.buttonsaatgönder);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textgönderilecekveri);
			this.Controls.Add(this.textdatabit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.baudrate);
			this.Controls.Add(this.textBaudrate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textcom);
			this.Controls.Add(this.btnkapa);
			this.Controls.Add(this.btnac);
			this.Name = "MainForm";
			this.Text = "seriportodev";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
