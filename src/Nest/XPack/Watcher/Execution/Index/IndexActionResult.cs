// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

﻿using System.Runtime.Serialization;

namespace Nest
{
	[DataContract]
	public class IndexActionResult
	{
		[DataMember(Name ="id")]
		public string Id { get; set; }

		[DataMember(Name ="response")]
		public IndexActionResultIndexResponse Response { get; set; }
	}
}
