/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsGroupListResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private List<OnsGroupList_SubscribeInfoDo> data;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public List<OnsGroupList_SubscribeInfoDo> Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class OnsGroupList_SubscribeInfoDo
		{

			private string owner;

			private string groupId;

			private long? updateTime;

			private string remark;

			private string instanceId;

			private bool? independentNaming;

			private long? createTime;

			private string groupType;

			public string Owner
			{
				get
				{
					return owner;
				}
				set	
				{
					owner = value;
				}
			}

			public string GroupId
			{
				get
				{
					return groupId;
				}
				set	
				{
					groupId = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public bool? IndependentNaming
			{
				get
				{
					return independentNaming;
				}
				set	
				{
					independentNaming = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string GroupType
			{
				get
				{
					return groupType;
				}
				set	
				{
					groupType = value;
				}
			}
		}
	}
}
