using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public class api
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00005E40 File Offset: 0x00004040
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Application not setup correctly. Please watch video link found in Program.cs");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00005ED4 File Offset: 0x000040D4
		public void init()
		{
			this.enckey = encryption.sha256(encryption.iv_key());
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, init_iv);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.enckey, this.secret, init_iv);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			if (response == "KeyAuth_Invalid")
			{
				api.error("Application not found");
				Environment.Exit(0);
			}
			response = encryption.decrypt(response, this.secret, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				this.load_app_data(json.appinfo);
				this.sessionid = json.sessionid;
				this.initzalized = true;
				return;
			}
			if (json.message == "invalidver")
			{
				this.app_data.downloadLink = json.download;
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00006055 File Offset: 0x00004255
		public static bool IsDebugRelease
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00006058 File Offset: 0x00004258
		public void Checkinit()
		{
			if (!this.initzalized)
			{
				if (api.IsDebugRelease)
				{
					api.error("Not initialized Check if KeyAuthApp.init() does exist");
					return;
				}
				api.error("Please initialize first");
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00006080 File Offset: 0x00004280
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string hwid = WindowsIdentity.GetCurrent().User.Value;
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, init_iv);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, init_iv);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, init_iv);
			nameValueCollection["hwid"] = encryption.encrypt(hwid, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				this.load_user_data(json.info);
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000061DC File Offset: 0x000043DC
		public void login(string username, string pass)
		{
			this.Checkinit();
			string hwid = WindowsIdentity.GetCurrent().User.Value;
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, init_iv);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.enckey, init_iv);
			nameValueCollection["hwid"] = encryption.encrypt(hwid, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				this.load_user_data(json.info);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00006320 File Offset: 0x00004520
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.enckey, init_iv);
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			json.success = false;
			this.load_response_struct(json);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00006440 File Offset: 0x00004640
		public void license(string key)
		{
			this.Checkinit();
			string hwid = WindowsIdentity.GetCurrent().User.Value;
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.enckey, init_iv);
			nameValueCollection["hwid"] = encryption.encrypt(hwid, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				this.load_user_data(json.info);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000656C File Offset: 0x0000476C
		public void check()
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00006644 File Offset: 0x00004844
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, init_iv);
			nameValueCollection["data"] = encryption.encrypt(data, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000674C File Offset: 0x0000494C
		public string getvar(string var)
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				return json.response;
			}
			return null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000684C File Offset: 0x00004A4C
		public void ban()
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006924 File Offset: 0x00004B24
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				return json.message;
			}
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00006A34 File Offset: 0x00004C34
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				return json.messages;
			}
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00006B34 File Offset: 0x00004D34
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.enckey, init_iv);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			return json.success;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006C48 File Offset: 0x00004E48
		public bool checkblack()
		{
			this.Checkinit();
			string hwid = WindowsIdentity.GetCurrent().User.Value;
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(hwid, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			return json.success;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006D54 File Offset: 0x00004F54
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.enckey, init_iv);
			nameValueCollection["params"] = encryption.encrypt(param, this.enckey, init_iv);
			nameValueCollection["body"] = encryption.encrypt(body, this.enckey, init_iv);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				return json.response;
			}
			return null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00006E9C File Offset: 0x0000509C
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			string response = api.req(nameValueCollection);
			response = encryption.decrypt(response, this.enckey, init_iv);
			api.response_structure json = this.response_decoder.string_to_generic<api.response_structure>(response);
			this.load_response_struct(json);
			if (json.success)
			{
				return encryption.str_to_byte_arr(json.contents);
			}
			return null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00006FA0 File Offset: 0x000051A0
		public void log(string message)
		{
			this.Checkinit();
			string init_iv = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.enckey, init_iv);
			nameValueCollection["message"] = encryption.encrypt(message, this.enckey, init_iv);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.sessionid));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = init_iv;
			api.req(nameValueCollection);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00007088 File Offset: 0x00005288
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					result = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000070F8 File Offset: 0x000052F8
		public static void error(string message)
		{
			Process.Start(new ProcessStartInfo("cmd.exe", "/c start cmd /C \"color b && title Error && echo " + message + " && timeout /t 5\"")
			{
				CreateNoWindow = true,
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false
			});
			Environment.Exit(0);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00007148 File Offset: 0x00005348
		private static string req(NameValueCollection post_data)
		{
			string result;
			try
			{
				using (WebClient client = new WebClient())
				{
					byte[] raw_response = client.UploadValues("https://keyauth.win/api/1.0/", post_data);
					result = Encoding.Default.GetString(raw_response);
				}
			}
			catch (WebException ex)
			{
				if (((HttpWebResponse)ex.Response).StatusCode == (HttpStatusCode)429)
				{
					api.error("You're connecting too fast to loader, slow down.");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("Connection failure. Please try again, or contact us for help.");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000071E4 File Offset: 0x000053E4
		private void load_app_data(api.app_data_structure data)
		{
			this.app_data.numUsers = data.numUsers;
			this.app_data.numOnlineUsers = data.numOnlineUsers;
			this.app_data.numKeys = data.numKeys;
			this.app_data.version = data.version;
			this.app_data.customerPanelLink = data.customerPanelLink;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00007248 File Offset: 0x00005448
		private void load_user_data(api.user_data_structure data)
		{
			this.user_data.username = data.username;
			this.user_data.ip = data.ip;
			this.user_data.hwid = data.hwid;
			this.user_data.createdate = data.createdate;
			this.user_data.lastlogin = data.lastlogin;
			this.user_data.subscriptions = data.subscriptions;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000072BC File Offset: 0x000054BC
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			dtDateTime = dtDateTime.AddSeconds((double)long.Parse(this.user_data.subscriptions[0].expiry)).ToLocalTime();
			TimeSpan difference = dtDateTime - DateTime.Now;
			return Convert.ToString(difference.Days.ToString() + " Days " + difference.Hours.ToString() + " Hours Left");
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000734C File Offset: 0x0000554C
		private void load_response_struct(api.response_structure data)
		{
			this.response.success = data.success;
			this.response.message = data.message;
		}

		// Token: 0x04000045 RID: 69
		public string name;

		// Token: 0x04000046 RID: 70
		public string ownerid;

		// Token: 0x04000047 RID: 71
		public string secret;

		// Token: 0x04000048 RID: 72
		public string version;

		// Token: 0x04000049 RID: 73
		private string sessionid;

		// Token: 0x0400004A RID: 74
		private string enckey;

		// Token: 0x0400004B RID: 75
		private bool initzalized;

		// Token: 0x0400004C RID: 76
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x0400004D RID: 77
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x0400004E RID: 78
		public api.response_class response = new api.response_class();

		// Token: 0x0400004F RID: 79
		private json_wrapper response_decoder = new json_wrapper(new api.response_structure());

		// Token: 0x02000007 RID: 7
		[DataContract]
		private class response_structure
		{
			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000038 RID: 56 RVA: 0x00007370 File Offset: 0x00005570
			// (set) Token: 0x06000039 RID: 57 RVA: 0x00007378 File Offset: 0x00005578
			[DataMember]
			public bool success { get; set; }

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00007381 File Offset: 0x00005581
			// (set) Token: 0x0600003B RID: 59 RVA: 0x00007389 File Offset: 0x00005589
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00007392 File Offset: 0x00005592
			// (set) Token: 0x0600003D RID: 61 RVA: 0x0000739A File Offset: 0x0000559A
			[DataMember]
			public string contents { get; set; }

			// Token: 0x17000005 RID: 5
			// (get) Token: 0x0600003E RID: 62 RVA: 0x000073A3 File Offset: 0x000055A3
			// (set) Token: 0x0600003F RID: 63 RVA: 0x000073AB File Offset: 0x000055AB
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000040 RID: 64 RVA: 0x000073B4 File Offset: 0x000055B4
			// (set) Token: 0x06000041 RID: 65 RVA: 0x000073BC File Offset: 0x000055BC
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000042 RID: 66 RVA: 0x000073C5 File Offset: 0x000055C5
			// (set) Token: 0x06000043 RID: 67 RVA: 0x000073CD File Offset: 0x000055CD
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x06000044 RID: 68 RVA: 0x000073D6 File Offset: 0x000055D6
			// (set) Token: 0x06000045 RID: 69 RVA: 0x000073DE File Offset: 0x000055DE
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x06000046 RID: 70 RVA: 0x000073E7 File Offset: 0x000055E7
			// (set) Token: 0x06000047 RID: 71 RVA: 0x000073EF File Offset: 0x000055EF
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000048 RID: 72 RVA: 0x000073F8 File Offset: 0x000055F8
			// (set) Token: 0x06000049 RID: 73 RVA: 0x00007400 File Offset: 0x00005600
			[DataMember]
			public List<api.msg> messages { get; set; }
		}

		// Token: 0x02000008 RID: 8
		public class msg
		{
			// Token: 0x1700000B RID: 11
			// (get) Token: 0x0600004B RID: 75 RVA: 0x00007411 File Offset: 0x00005611
			// (set) Token: 0x0600004C RID: 76 RVA: 0x00007419 File Offset: 0x00005619
			public string message { get; set; }

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x0600004D RID: 77 RVA: 0x00007422 File Offset: 0x00005622
			// (set) Token: 0x0600004E RID: 78 RVA: 0x0000742A File Offset: 0x0000562A
			public string author { get; set; }

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x0600004F RID: 79 RVA: 0x00007433 File Offset: 0x00005633
			// (set) Token: 0x06000050 RID: 80 RVA: 0x0000743B File Offset: 0x0000563B
			public string timestamp { get; set; }
		}

		// Token: 0x02000009 RID: 9
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000052 RID: 82 RVA: 0x00007444 File Offset: 0x00005644
			// (set) Token: 0x06000053 RID: 83 RVA: 0x0000744C File Offset: 0x0000564C
			[DataMember]
			public string username { get; set; }

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000054 RID: 84 RVA: 0x00007455 File Offset: 0x00005655
			// (set) Token: 0x06000055 RID: 85 RVA: 0x0000745D File Offset: 0x0000565D
			[DataMember]
			public string ip { get; set; }

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000056 RID: 86 RVA: 0x00007466 File Offset: 0x00005666
			// (set) Token: 0x06000057 RID: 87 RVA: 0x0000746E File Offset: 0x0000566E
			[DataMember]
			public string hwid { get; set; }

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000058 RID: 88 RVA: 0x00007477 File Offset: 0x00005677
			// (set) Token: 0x06000059 RID: 89 RVA: 0x0000747F File Offset: 0x0000567F
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600005A RID: 90 RVA: 0x00007488 File Offset: 0x00005688
			// (set) Token: 0x0600005B RID: 91 RVA: 0x00007490 File Offset: 0x00005690
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600005C RID: 92 RVA: 0x00007499 File Offset: 0x00005699
			// (set) Token: 0x0600005D RID: 93 RVA: 0x000074A1 File Offset: 0x000056A1
			[DataMember]
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000A RID: 10
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600005F RID: 95 RVA: 0x000074AA File Offset: 0x000056AA
			// (set) Token: 0x06000060 RID: 96 RVA: 0x000074B2 File Offset: 0x000056B2
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000061 RID: 97 RVA: 0x000074BB File Offset: 0x000056BB
			// (set) Token: 0x06000062 RID: 98 RVA: 0x000074C3 File Offset: 0x000056C3
			[DataMember]
			public string numOnlineUsers { get; set; }

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000063 RID: 99 RVA: 0x000074CC File Offset: 0x000056CC
			// (set) Token: 0x06000064 RID: 100 RVA: 0x000074D4 File Offset: 0x000056D4
			[DataMember]
			public string numKeys { get; set; }

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000065 RID: 101 RVA: 0x000074DD File Offset: 0x000056DD
			// (set) Token: 0x06000066 RID: 102 RVA: 0x000074E5 File Offset: 0x000056E5
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000067 RID: 103 RVA: 0x000074EE File Offset: 0x000056EE
			// (set) Token: 0x06000068 RID: 104 RVA: 0x000074F6 File Offset: 0x000056F6
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000069 RID: 105 RVA: 0x000074FF File Offset: 0x000056FF
			// (set) Token: 0x0600006A RID: 106 RVA: 0x00007507 File Offset: 0x00005707
			[DataMember]
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000B RID: 11
		public class app_data_class
		{
			// Token: 0x1700001A RID: 26
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00007510 File Offset: 0x00005710
			// (set) Token: 0x0600006D RID: 109 RVA: 0x00007518 File Offset: 0x00005718
			public string numUsers { get; set; }

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00007521 File Offset: 0x00005721
			// (set) Token: 0x0600006F RID: 111 RVA: 0x00007529 File Offset: 0x00005729
			public string numOnlineUsers { get; set; }

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x06000070 RID: 112 RVA: 0x00007532 File Offset: 0x00005732
			// (set) Token: 0x06000071 RID: 113 RVA: 0x0000753A File Offset: 0x0000573A
			public string numKeys { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00007543 File Offset: 0x00005743
			// (set) Token: 0x06000073 RID: 115 RVA: 0x0000754B File Offset: 0x0000574B
			public string version { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00007554 File Offset: 0x00005754
			// (set) Token: 0x06000075 RID: 117 RVA: 0x0000755C File Offset: 0x0000575C
			public string customerPanelLink { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00007565 File Offset: 0x00005765
			// (set) Token: 0x06000077 RID: 119 RVA: 0x0000756D File Offset: 0x0000576D
			public string downloadLink { get; set; }
		}

		// Token: 0x0200000C RID: 12
		public class user_data_class
		{
			// Token: 0x17000020 RID: 32
			// (get) Token: 0x06000079 RID: 121 RVA: 0x00007576 File Offset: 0x00005776
			// (set) Token: 0x0600007A RID: 122 RVA: 0x0000757E File Offset: 0x0000577E
			public string username { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600007B RID: 123 RVA: 0x00007587 File Offset: 0x00005787
			// (set) Token: 0x0600007C RID: 124 RVA: 0x0000758F File Offset: 0x0000578F
			public string ip { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x0600007D RID: 125 RVA: 0x00007598 File Offset: 0x00005798
			// (set) Token: 0x0600007E RID: 126 RVA: 0x000075A0 File Offset: 0x000057A0
			public string hwid { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x0600007F RID: 127 RVA: 0x000075A9 File Offset: 0x000057A9
			// (set) Token: 0x06000080 RID: 128 RVA: 0x000075B1 File Offset: 0x000057B1
			public string createdate { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000081 RID: 129 RVA: 0x000075BA File Offset: 0x000057BA
			// (set) Token: 0x06000082 RID: 130 RVA: 0x000075C2 File Offset: 0x000057C2
			public string lastlogin { get; set; }

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000083 RID: 131 RVA: 0x000075CB File Offset: 0x000057CB
			// (set) Token: 0x06000084 RID: 132 RVA: 0x000075D3 File Offset: 0x000057D3
			public List<api.Data> subscriptions { get; set; }
		}

		// Token: 0x0200000D RID: 13
		public class Data
		{
			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000086 RID: 134 RVA: 0x000075DC File Offset: 0x000057DC
			// (set) Token: 0x06000087 RID: 135 RVA: 0x000075E4 File Offset: 0x000057E4
			public string subscription { get; set; }

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000088 RID: 136 RVA: 0x000075ED File Offset: 0x000057ED
			// (set) Token: 0x06000089 RID: 137 RVA: 0x000075F5 File Offset: 0x000057F5
			public string expiry { get; set; }

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600008A RID: 138 RVA: 0x000075FE File Offset: 0x000057FE
			// (set) Token: 0x0600008B RID: 139 RVA: 0x00007606 File Offset: 0x00005806
			public string timeleft { get; set; }
		}

		// Token: 0x0200000E RID: 14
		public class response_class
		{
			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600008D RID: 141 RVA: 0x0000760F File Offset: 0x0000580F
			// (set) Token: 0x0600008E RID: 142 RVA: 0x00007617 File Offset: 0x00005817
			public bool success { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00007620 File Offset: 0x00005820
			// (set) Token: 0x06000090 RID: 144 RVA: 0x00007628 File Offset: 0x00005828
			public string message { get; set; }
		}
	}
}
