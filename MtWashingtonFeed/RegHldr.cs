using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace MtWashingtonFeed
{
    /// <summary>
    /// Reg
    /// </summary>
    public class RegHdlr
    {
        /// <summary>
        /// Reg
        /// </summary>
        public RegHdlr(string aRegistryHome)
        {
            try
            {
                UserKey = Registry.CurrentUser;
                SoftwareKey = UserKey.CreateSubKey(aRegistryHome,
                    RegistryKeyPermissionCheck.ReadWriteSubTree);
            }
            catch (Exception ex) { throw new ApplicationException("Registry exception", ex); }
        }

        #region Instance Fields

        /// <summary>
        /// UserKey
        /// </summary>
        public RegistryKey UserKey;

        /// <summary>
        /// SoftwareKey
        /// </summary>
        public RegistryKey SoftwareKey;

        #endregion
    }
}
