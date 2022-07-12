using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace KeyAuth
{
	// Token: 0x0200000F RID: 15
	public static class encryption
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00007634 File Offset: 0x00005834
		public static string byte_arr_to_str(byte[] ba)
		{
			StringBuilder hex = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
			{
				hex.AppendFormat("{0:x2}", b);
			}
			return hex.ToString();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00007678 File Offset: 0x00005878
		public static byte[] str_to_byte_arr(string hex)
		{
			byte[] result;
			try
			{
				int NumberChars = hex.Length;
				byte[] bytes = new byte[NumberChars / 2];
				for (int i = 0; i < NumberChars; i += 2)
				{
					bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
				}
				result = bytes;
			}
			catch
			{
				Console.WriteLine("\n\n  The session has ended, open program again.");
				Thread.Sleep(3500);
				Environment.Exit(0);
				result = null;
			}
			return result;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000076EC File Offset: 0x000058EC
		public static string encrypt_string(string plain_text, byte[] key, byte[] iv)
		{
			Aes encryptor = Aes.Create();
			encryptor.Mode = CipherMode.CBC;
			encryptor.Key = key;
			encryptor.IV = iv;
			string result;
			using (MemoryStream mem_stream = new MemoryStream())
			{
				using (ICryptoTransform aes_encryptor = encryptor.CreateEncryptor())
				{
					using (CryptoStream crypt_stream = new CryptoStream(mem_stream, aes_encryptor, CryptoStreamMode.Write))
					{
						byte[] p_bytes = Encoding.Default.GetBytes(plain_text);
						crypt_stream.Write(p_bytes, 0, p_bytes.Length);
						crypt_stream.FlushFinalBlock();
						result = encryption.byte_arr_to_str(mem_stream.ToArray());
					}
				}
			}
			return result;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000077A4 File Offset: 0x000059A4
		public static string decrypt_string(string cipher_text, byte[] key, byte[] iv)
		{
			Aes encryptor = Aes.Create();
			encryptor.Mode = CipherMode.CBC;
			encryptor.Key = key;
			encryptor.IV = iv;
			string @string;
			using (MemoryStream mem_stream = new MemoryStream())
			{
				using (ICryptoTransform aes_decryptor = encryptor.CreateDecryptor())
				{
					using (CryptoStream crypt_stream = new CryptoStream(mem_stream, aes_decryptor, CryptoStreamMode.Write))
					{
						byte[] c_bytes = encryption.str_to_byte_arr(cipher_text);
						crypt_stream.Write(c_bytes, 0, c_bytes.Length);
						crypt_stream.FlushFinalBlock();
						byte[] p_bytes = mem_stream.ToArray();
						@string = Encoding.Default.GetString(p_bytes, 0, p_bytes.Length);
					}
				}
			}
			return @string;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00007864 File Offset: 0x00005A64
		public static string iv_key()
		{
			return Guid.NewGuid().ToString().Substring(0, Guid.NewGuid().ToString().IndexOf("-", StringComparison.Ordinal));
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000078A8 File Offset: 0x00005AA8
		public static string sha256(string r)
		{
			return encryption.byte_arr_to_str(new SHA256Managed().ComputeHash(Encoding.Default.GetBytes(r)));
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000078C4 File Offset: 0x00005AC4
		public static string encrypt(string message, string enc_key, string iv)
		{
			byte[] _key = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32));
			byte[] _iv = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16));
			return encryption.encrypt_string(message, _key, _iv);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000790C File Offset: 0x00005B0C
		public static string decrypt(string message, string enc_key, string iv)
		{
			byte[] _key = Encoding.Default.GetBytes(encryption.sha256(enc_key).Substring(0, 32));
			byte[] _iv = Encoding.Default.GetBytes(encryption.sha256(iv).Substring(0, 16));
			return encryption.decrypt_string(message, _key, _iv);
		}
	}
}
