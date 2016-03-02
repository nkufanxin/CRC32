using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CRC32
{
    public class CRC32Cls
    {
        static protected UInt32[] CrcTable;
        //生成CRC32码表
        static public void GetCRCTable()
        {
            UInt32 Crc;
            CrcTable = new UInt32[256];
            int i, j;
            for (i = 0; i < 256; i++)
            {
                Crc = (UInt32)i;
                for (j = 8; j > 0; j--)
                {
                    if ((Crc & 1) == 1)
                        Crc = (Crc >> 1) ^ 0xEDB88320;
                    else
                        Crc >>= 1;
                }
                CrcTable[i] = Crc;
            }
        }
        //获取字符串的CRC32校验值
        static public UInt32 CRC_32(string Inputstr)
        {
            //生成码表
            GetCRCTable();
            byte[] bytes = System.Text.Encoding.Default.GetBytes(Inputstr);//解决中文的问题
            int iCount = bytes.Length;
            UInt32 crc = 0xFFFFFFFF;
            for (int i = 0; i < iCount; i++)
            {
                crc = ((crc >> 8) & 0x00FFFFFF) ^ CrcTable[(crc ^ bytes[i]) & 0xFF];
            }
            UInt32 temp = crc ^ 0xFFFFFFFF;
            return temp;
        }
    }
   
    public class CRC32
    {
        public List<string> frameBody_list = new List<string>();
        public List<string> crc32Code_list = new List<string>();
        const int BUFSIZE = 2312-4;     
        public void CRC32_cleanUp()
        {
            frameBody_list.Clear();
            crc32Code_list.Clear();            
        }

       
        public UInt32 calc_text_crc(string in_file)
        {
            char[] buf = new char[BUFSIZE+4];
            /*第一次传入的值需要固定,如果发送端使用该值计算crc校验码, 
            **那么接收端也同样需要使用该值进行计算*/
            UInt32 crc = 0;

            string strReadFilePath = in_file;
            StreamReader srReadFile = new StreamReader(strReadFilePath);
            // 读取流直至文件末尾结束            
            while (!srReadFile.EndOfStream)
            {
                int readCount = srReadFile.Read(buf, 0, BUFSIZE); 
               //MessageBox.Show(readCount.ToString()); //屏幕打印每行数据
                string Crcbody = new String(buf, 0, readCount);
                byte[] array_Crcbody = System.Text.Encoding.ASCII.GetBytes(Crcbody); //数组array为对应的ASCII数组 
                string ASCIIstr_Crcbody = null;
                for (int i = 0; i < array_Crcbody.Length; i++)
                {
                    int asciicode = (int)(array_Crcbody[i]);
                    ASCIIstr_Crcbody += Convert.ToString(asciicode,16);//字符串ASCIIstr2 为对应的ASCII字符串
                }
                frameBody_list.Add(ASCIIstr_Crcbody);

                crc = CRC32Cls.CRC_32(Crcbody);
                byte[] array_Crcvalue = System.Text.Encoding.ASCII.GetBytes(Crcbody); //数组array为对应的ASCII数组 
                string ASCIIstr_Crcvalue = null;
                for (int i = 0; i < array_Crcvalue.Length; i++)
                {
                    int asciicode = (int)(array_Crcbody[i]);
                    ASCIIstr_Crcvalue += Convert.ToString(asciicode, 16);//字符串ASCIIstr2 为对应的ASCII字符串
                }

                crc32Code_list.Add(ASCIIstr_Crcvalue);
            }
            // 关闭读取流文件
            srReadFile.Close();            
            return crc;
        }
    }
}
