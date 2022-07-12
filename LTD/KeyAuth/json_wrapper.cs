using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace KeyAuth
{
	// Token: 0x02000010 RID: 16
	public class json_wrapper
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00007953 File Offset: 0x00005B53
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00007970 File Offset: 0x00005B70
		public json_wrapper(object obj_to_work_with)
		{
			this.current_object = obj_to_work_with;
			Type object_type = this.current_object.GetType();
			this.serializer = new DataContractJsonSerializer(object_type);
			if (!json_wrapper.is_serializable(object_type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.current_object));
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000079C0 File Offset: 0x00005BC0
		public object string_to_object(string json)
		{
			object result;
			using (MemoryStream mem_stream = new MemoryStream(Encoding.Default.GetBytes(json)))
			{
				result = this.serializer.ReadObject(mem_stream);
			}
			return result;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00007A08 File Offset: 0x00005C08
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x04000079 RID: 121
		private DataContractJsonSerializer serializer;

		// Token: 0x0400007A RID: 122
		private object current_object;
	}
}
