// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.SiteRecovery.Models
{
    /// <summary>
    /// InMageAzureV2 protected volume details.
    /// </summary>
    public partial class InMageAzureV2ProtectedVolumeDetails
    {
        private long _fileSystemCapacityInBytes;
        
        /// <summary>
        /// Optional. File system capacity in bytes.
        /// </summary>
        public long FileSystemCapacityInBytes
        {
            get { return this._fileSystemCapacityInBytes; }
            set { this._fileSystemCapacityInBytes = value; }
        }
        
        private string _healthErrorCode;
        
        /// <summary>
        /// Optional. Health error code for the volume.
        /// </summary>
        public string HealthErrorCode
        {
            get { return this._healthErrorCode; }
            set { this._healthErrorCode = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Volume name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _protectionStage;
        
        /// <summary>
        /// Optional. Protection stage.
        /// </summary>
        public string ProtectionStage
        {
            get { return this._protectionStage; }
            set { this._protectionStage = value; }
        }
        
        private double _pSDataInMB;
        
        /// <summary>
        /// Optional. PS data transit in MB.
        /// </summary>
        public double PSDataInMB
        {
            get { return this._pSDataInMB; }
            set { this._pSDataInMB = value; }
        }
        
        private long _resyncDurationInSeconds;
        
        /// <summary>
        /// Optional. Resync duration in seconds.
        /// </summary>
        public long ResyncDurationInSeconds
        {
            get { return this._resyncDurationInSeconds; }
            set { this._resyncDurationInSeconds = value; }
        }
        
        private int _resyncProgressPercentage;
        
        /// <summary>
        /// Optional. Resync progress percentage.
        /// </summary>
        public int ResyncProgressPercentage
        {
            get { return this._resyncProgressPercentage; }
            set { this._resyncProgressPercentage = value; }
        }
        
        private bool _resyncRequired;
        
        /// <summary>
        /// Optional. Value indicating whether resync is required for this
        /// volume.
        /// </summary>
        public bool ResyncRequired
        {
            get { return this._resyncRequired; }
            set { this._resyncRequired = value; }
        }
        
        private long? _rpoInSeconds;
        
        /// <summary>
        /// Optional. RPO in seconds.
        /// </summary>
        public long? RpoInSeconds
        {
            get { return this._rpoInSeconds; }
            set { this._rpoInSeconds = value; }
        }
        
        private double _sourceDataInMB;
        
        /// <summary>
        /// Optional. Source data transit in MB.
        /// </summary>
        public double SourceDataInMB
        {
            get { return this._sourceDataInMB; }
            set { this._sourceDataInMB = value; }
        }
        
        private double _targetDataInMB;
        
        /// <summary>
        /// Optional. Target data transit in MB.
        /// </summary>
        public double TargetDataInMB
        {
            get { return this._targetDataInMB; }
            set { this._targetDataInMB = value; }
        }
        
        private long _volumeCapacityInBytes;
        
        /// <summary>
        /// Optional. Volume capacity in bytes.
        /// </summary>
        public long VolumeCapacityInBytes
        {
            get { return this._volumeCapacityInBytes; }
            set { this._volumeCapacityInBytes = value; }
        }
        
        private bool _volumeResized;
        
        /// <summary>
        /// Optional. Value indicating whether volume is resized.
        /// </summary>
        public bool VolumeResized
        {
            get { return this._volumeResized; }
            set { this._volumeResized = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// InMageAzureV2ProtectedVolumeDetails class.
        /// </summary>
        public InMageAzureV2ProtectedVolumeDetails()
        {
        }
    }
}
