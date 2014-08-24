﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dargon.PortableObjects
{
   public enum ReservedTypeId : int
   {
      TYPE_S8 = -1,
      TYPE_U8 = -2,
      TYPE_S16 = -3,
      TYPE_U16 = -4,
      TYPE_S32 = -5,
      TYPE_U32 = -6,
      TYPE_S64 = -7,
      TYPE_U64 = -8,
      TYPE_FLOAT = -9,
      TYPE_DOUBLE = -10,
      TYPE_CHAR = -11,
      TYPE_STRING = -12,
      TYPE_BOOL = -13
   }
}
