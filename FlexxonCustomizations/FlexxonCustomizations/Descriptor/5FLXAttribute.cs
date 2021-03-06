﻿// Decompiled with JetBrains decompiler
// Type: FlexxonCustomizations.Descriptor.SalesRepSelectorAttribute
// Assembly: FlexxonCustomizations, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A59FE566-6025-4730-961E-B73CC13C04A9
// Assembly location: C:\Program Files\Acumatica ERP\Flexxon\Bin\FlexxonCustomizations.dll

using FlexxonCustomizations.Graph;
using PX.Data;
using PX.Objects.CR;

namespace FlexxonCustomizations.Descriptor
{
  public class SalesRepSelectorAttribute : PXSelectorAttribute
  {
    public SalesRepSelectorAttribute()
      : base(typeof (Search<BAccountR.bAccountID, Where<PX.Objects.CR.BAccount.classID, Equal<FLXProjectEntry.SalesRepAtt>>>), typeof (BAccountR.acctCD), typeof (BAccountR.status), typeof (BAccountR.type), typeof (PX.Objects.CR.BAccount.classID))
    {
      this.IsDirty = true;
      this.SubstituteKey = typeof (BAccountR.acctCD);
    }

    public SalesRepSelectorAttribute(System.Type searchType)
      : base(searchType, typeof (BAccountR.acctCD), typeof (BAccountR.status), typeof (BAccountR.type), typeof (PX.Objects.CR.BAccount.classID))
      => this.SubstituteKey = typeof (BAccountR.acctCD);
  }
}
