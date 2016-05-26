﻿//
//  ReplicationTrigger.cs
//
//  Author:
//  	Jim Borden  <jim.borden@couchbase.com>
//
//  Copyright (c) 2015 Couchbase, Inc All rights reserved.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
using System;

namespace Couchbase.Lite.Replicator
{

    /// <summary>
    /// A set of triggers for the replication state machine
    /// </summary>
    public enum ReplicationTrigger
    {
        /// <summary>
        /// Triggers the replication to start
        /// </summary>
        Start,

        /// <summary>
        /// Triggers the replication to restart
        /// </summary>
        Restart,

        /// <summary>
        /// Triggers the replication to go idle and wait for new data
        /// </summary>
        WaitingForChanges,

        /// <summary>
        /// Triggers the replication to resume after becoming idle
        /// </summary>
        Resume,

        /// <summary>
        /// Triggers the replication to go offline
        /// </summary>
        GoOffline,

        /// <summary>
        /// Triggers the replication to go online
        /// </summary>
        GoOnline,

        /// <summary>
        /// Triggers the replication to shutdown and finish any pending work
        /// </summary>
        StopGraceful,

        /// <summary>
        /// Triggers the replication to shutdown and ignore any pending work
        /// </summary>
        StopImmediate
    }
}

