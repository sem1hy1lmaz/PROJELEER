/*
 * Created by SharpDevelop.
 * User: C M Y
 * Date: 2.12.2024
 * Time: 12:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace seriportodev
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string gelenveri=string.Empty;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		}
		void BtnacClick(object sender, EventArgs e)
		{  if (!serialPort1.IsOpen) {
			serialPort1.PortName=textcom.Text;
			serialPort1.BaudRate=Convert.ToInt32(textBaudrate.Text);
			serialPort1.DataBits=Convert.ToInt32(textdatabit.Text);
			serialPort1.Open(); }
		}
		void BtnkapaClick(object sender, EventArgs e)
		{ if (serialPort1.IsOpen){
				serialPort1.Close();
			}
	
		}
		void ButtonsaatgönderClick(object sender, EventArgs e)
		{  string saatVerisi = textbaşlangıç.Text; // Kullanıcıdan gelen veri (HH:MM:SS)
           serialPort1.Write("[" + saatVerisi + "]"); // Saat verisini Tiva'ya gönder
		
		}
		void SerialPort1DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{  gelenveri=serialPort1.ReadLine();
			this.Invoke(new EventHandler(DisplayText));
		}
			private void DisplayText(object sender,EventArgs e)
			{ textgelenveri.Text=gelenveri;
							textgelenveri.Text=gelenveri;
			if(gelenveri[0]=='{'){
				
				textMCdengelen.Text=gelenveri.Substring(1,8);
				
			}
			else if (gelenveri[0]=='('){
				textADCverisi.Text=gelenveri.Substring(1,4);
			}
			else if (gelenveri[0]=='['){
				textgönderilecekveri.Text=gelenveri;
			}
		}
		
		
	
	}}
	

        


   
			
		
		
	
	
		
		
		
	
		
	    
	

		
	         
	  
	     
	
		
	
		
			
		
		
		
		
		
	

