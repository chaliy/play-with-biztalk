namespace PlayWithBizTalk {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PlayWithBizTalk.Recall", typeof(global::PlayWithBizTalk.Recall))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"PlayWithBizTalk.Recall", typeof(global::PlayWithBizTalk.Recall))]
    public sealed class DecomposeMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://dev.local/recall"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:Recall"" />
  </xsl:template>
  <xsl:template match=""/ns0:Recall"">
    <ns0:Recall>
      <ns0:SerialNumber>
        <xsl:value-of select=""ns0:SerialNumber/text()"" />
      </ns0:SerialNumber>
      <xsl:value-of select=""./text()"" />
    </ns0:Recall>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"PlayWithBizTalk.Recall";
        
        private const global::PlayWithBizTalk.Recall _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"PlayWithBizTalk.Recall";
        
        private const global::PlayWithBizTalk.Recall _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"PlayWithBizTalk.Recall";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"PlayWithBizTalk.Recall";
                return _TrgSchemas;
            }
        }
    }
}
