/*
 * Created by SharpDevelop.
 * User: Fatih
 * Date: 13.12.2018
 * Time: 19:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace TwineProjectCrypto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		byte[] sbox={0x0C, 0x00, 0x0F, 0x0A, 0x02, 0x0B, 0x09, 0x05, 0x08, 0x03, 0x0D, 0x07, 0x01, 0x0E, 0x06, 0x04};
		int[] shuf={5, 0, 1, 4, 7, 12, 3, 8, 13, 6, 9, 2, 15, 10, 11, 14};
		int[] shufinv={1, 2, 11, 6, 3, 0, 9, 4, 7, 10, 13, 14, 5, 8, 15, 12};
		byte[] roundconst={
		0x01, 0x02, 0x04, 0x08, 0x10, 0x20, 0x03, 0x06, 0x0c, 0x18, 0x30, 0x23, 0x05, 0x0a, 0x14, 0x28, 0x13, 0x26,
		0x0f, 0x1e, 0x3c, 0x3b, 0x35, 0x29, 0x11, 0x22, 0x07, 0x0e, 0x1c, 0x38, 0x33, 0x25, 0x09, 0x12, 0x24, 0x0b};
		byte[,] rk=new byte[36,8];
		byte[] crt_byte=new byte[8];
		byte[] dec_byte=new byte[8];
		
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
		void CryptoClick(object sender, EventArgs e)
		{
			string k=Key.Text;
			string[] plainArray = new string[100];

			
			if(k.Length==10)
			{
				label5.Text="";
				New(k);
				string plaintxt=PlainText.Text;
				
				int counter=0;
				for(int i=0;i<plaintxt.Length;i+=8)
				{
					if(plaintxt.Length-i<=8)
						plainArray[counter]=plaintxt.Substring(i,plaintxt.Length-i);
					else
						plainArray[counter]=plaintxt.Substring(i,8);		
					counter+=1;
				}
				string s="",cs="";
				for(int i=0;i<counter;i++)
				{
					byte[] cryptotext=Encrypt(plainArray[i]);
					s+=Encoding.ASCII.GetString(cryptotext);
					cs+=Decrypt(cryptotext);
				}
				CryptoText.Text=s;
				plaint.Text=cs;
			}
			else
			{
				label5.Text="Key length should be 10";
				label5.ForeColor=Color.Red;
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		
		
		void New(string NewKEY)
		{
			byte[] wk=new byte[20];
			byte[] keyBytes=Encoding.ASCII.GetBytes(NewKEY);
			for(int i=0;i<keyBytes.Length;i++)
			{
				wk[2*i] = Convert.ToByte(keyBytes[i] >> 4);
				wk[2*i+1] = Convert.ToByte(keyBytes[i] & 0x0f);
			}
			for(int i=0;i<35;i++)
			{
				rk[i,0] = wk[1];
				rk[i,1] = wk[3];
				rk[i,2] = wk[4];
				rk[i,3] = wk[6];
				rk[i,4] = wk[13];
				rk[i,5] = wk[14];
				rk[i,6] = wk[15];
				rk[i,7] = wk[16];
				wk[1] ^= sbox[wk[0]];
				wk[4] ^= sbox[wk[16]];
				wk[7] ^= Convert.ToByte(roundconst[i] >> 3);
				wk[19] ^= Convert.ToByte(roundconst[i] & 7);
				byte tmp0=wk[0],tmp1=wk[1],tmp2=wk[2],tmp3=wk[3];
				int fourj;
				for (int j = 0; j < 4; j++) {
					fourj = j * 4;
					wk[fourj] = wk[fourj+4];
					wk[fourj+1] = wk[fourj+5];
					wk[fourj+2] = wk[fourj+6];
					wk[fourj+3] = wk[fourj+7];
				}
				wk[16] = tmp1;
				wk[17] = tmp2;
				wk[18] = tmp3;
				wk[19] = tmp0;
			}
			rk[35,0] = wk[1];
			rk[35,1] = wk[3];
			rk[35,2] = wk[4];
			rk[35,3] = wk[6];
			rk[35,4] = wk[13];
			rk[35,5] = wk[14];
			rk[35,6] = wk[15];
			rk[35,7] = wk[16];
		}
		
		byte[] Encrypt(string plaintxt)
		{
			byte[] x=new byte[16];
			byte[] plaintxtByte=Encoding.ASCII.GetBytes(plaintxt);
			
			for (int i= 0; i < plaintxtByte.Length; i++) {
				x[2*i] = Convert.ToByte(plaintxtByte[i] >> 4);
				x[2*i+1] = Convert.ToByte(plaintxtByte[i] & 0x0f);
			}
			
			for (int i = 0; i < 35; i++) 
			{
				for (int j = 0; j < 8; j++) 
				{
					x[2*j+1] ^= sbox[x[2*j]^rk[i,j]];
				}		
	
				byte[] xnext=new byte[16];
				for (int h = 0; h < 16; h++) 
				{
					xnext[shuf[h]] = x[h];
				}
				x = xnext;
			}
			// last round

		for (int j = 0; j < 8; j++) 
		{
			x[2*j+1] ^= sbox[x[2*j]^rk[35,j]];
		}
		byte[] dst=new byte[8];
		for (int i = 0; i < 8; i++) 
		{
			dst[i] = Convert.ToByte((x[2*i] <<4) | x[2*i+1]);
		}
		crt_byte=dst;
		return dst;
		}
		string Decrypt(byte[] plaintxtByte)
		{
			byte[] x=new byte[16];
			dec_byte=plaintxtByte;
			for (int i= 0; i < plaintxtByte.Length; i++) {
				x[2*i] = Convert.ToByte(plaintxtByte[i] >> 4);
				x[2*i+1] = Convert.ToByte(plaintxtByte[i] & 0x0f);
			}
			for (int i = 35; i >= 1; i--)
			{
				for (int j = 0; j < 8; j++)
				{
					x[2*j+1] ^= sbox[x[2*j]^rk[i,j]];
				}
		
				byte[] xnext=new byte[16];
				for (int h = 0 ;h < 16; h++)
				{
					xnext[shufinv[h]] = x[h];
				}
				x = xnext;
			}
			
			for (int j = 0; j < 8; j++) 
			{
				x[2*j+1] ^= sbox[x[2*j]^rk[0,j]];
			}
			byte[] dst=new byte[8];
			for (int i = 0; i < 8; i++) 
			{
				dst[i] = Convert.ToByte((x[2*i] << 4) | x[2*i+1]);
			}
			
			return Encoding.ASCII.GetString(dst);
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		
	}
}
