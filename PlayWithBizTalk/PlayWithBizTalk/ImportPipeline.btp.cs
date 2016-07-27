namespace PlayWithBizTalk
{
    using System;
    using System.Collections.Generic;
    using Microsoft.BizTalk.PipelineOM;
    using Microsoft.BizTalk.Component;
    using Microsoft.BizTalk.Component.Interop;
    
    
    public sealed class ImportPipeline : Microsoft.BizTalk.PipelineOM.ReceivePipeline
    {
        
        private const string _strPipeline = "<?xml version=\"1.0\" encoding=\"utf-16\"?><Document xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instanc"+
"e\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" MajorVersion=\"1\" MinorVersion=\"0\">  <Description /> "+
" <CategoryId>f66b9f5e-43ff-4f5f-ba46-885348ae1b4e</CategoryId>  <FriendlyName>Receive</FriendlyName>"+
"  <Stages>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"1\" Name=\"Decode\" minOccurs=\""+
"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e4103-4cce-4536-83fa-4a5040674ad6\" />      <Component"+
"s />    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID=\"2\" Name=\"Disassemble\" "+
"minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"FirstMatch\" stageId=\"9d0e4105-4cce-4536-83fa-4a5040674ad6\" "+
"/>      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.XmlDasmComp,Micro"+
"soft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35<"+
"/Name>          <ComponentName>XML disassembler</ComponentName>          <Description>Streaming XML "+
"disassembler</Description>          <Version>1.0</Version>          <Properties>            <Propert"+
"y Name=\"EnvelopeSpecNames\">              <Value xsi:type=\"xsd:string\">PlayWithBizTalk.Input</Value> "+
"           </Property>            <Property Name=\"EnvelopeSpecTargetNamespaces\">              <Value"+
" xsi:type=\"xsd:string\">http://dev.local/input</Value>            </Property>            <Property Na"+
"me=\"DocumentSpecNames\">              <Value xsi:type=\"xsd:string\">PlayWithBizTalk.Recall</Value>    "+
"        </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">              <Value xs"+
"i:type=\"xsd:string\">http://dev.local/recall</Value>            </Property>            <Property Name"+
"=\"AllowUnrecognizedMessage\">              <Value xsi:type=\"xsd:boolean\">false</Value>            </P"+
"roperty>            <Property Name=\"ValidateDocument\">              <Value xsi:type=\"xsd:boolean\">fa"+
"lse</Value>            </Property>            <Property Name=\"RecoverableInterchangeProcessing\">    "+
"          <Value xsi:type=\"xsd:boolean\">true</Value>            </Property>            <Property Nam"+
"e=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,Documen"+
"tSpecTargetNamespaces</Value>            </Property>          </Properties>          <CachedDisplayN"+
"ame>XML disassembler</CachedDisplayName>          <CachedIsManaged>true</CachedIsManaged>        </C"+
"omponent>      </Components>    </Stage>    <Stage>      <PolicyFileStage _locAttrData=\"Name\" _locID"+
"=\"3\" Name=\"Validate\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId=\"9d0e410d-4cce-4536-83fa-"+
"4a5040674ad6\" />      <Components>        <Component>          <Name>Microsoft.BizTalk.Component.Xml"+
"Validator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31"+
"bf3856ad364e35</Name>          <ComponentName>XML validator</ComponentName>          <Description>XM"+
"L validator component.</Description>          <Version>1.0</Version>          <Properties>          "+
"  <Property Name=\"DocumentSpecName\">              <Value xsi:type=\"xsd:string\">PlayWithBizTalk.Recal"+
"l</Value>            </Property>            <Property Name=\"DocumentSpecTargetNamespaces\">          "+
"    <Value xsi:type=\"xsd:string\">http://dev.local/recall</Value>            </Property>            <"+
"Property Name=\"HiddenProperties\">              <Value xsi:type=\"xsd:string\">DocumentSpecTargetNamesp"+
"aces</Value>            </Property>            <Property Name=\"RecoverableInterchangeProcessing\">   "+
"           <Value xsi:type=\"xsd:boolean\">false</Value>            </Property>          </Properties>"+
"          <CachedDisplayName>XML validator</CachedDisplayName>          <CachedIsManaged>true</Cache"+
"dIsManaged>        </Component>      </Components>    </Stage>    <Stage>      <PolicyFileStage _loc"+
"AttrData=\"Name\" _locID=\"4\" Name=\"ResolveParty\" minOccurs=\"0\" maxOccurs=\"-1\" execMethod=\"All\" stageId"+
"=\"9d0e410e-4cce-4536-83fa-4a5040674ad6\" />      <Components />    </Stage>  </Stages></Document>";
        
        private const string _versionDependentGuid = "f6686d76-c7c4-4c87-bb0c-3e5eb05def7d";
        
        public ImportPipeline()
        {
            Microsoft.BizTalk.PipelineOM.Stage stage = this.AddStage(new System.Guid("9d0e4105-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.firstRecognized);
            IBaseComponent comp0 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlDasmComp,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp0 is IPersistPropertyBag)
            {
                string comp0XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"EnvelopeSpecNam"+
"es\">      <Value xsi:type=\"xsd:string\">PlayWithBizTalk.Input</Value>    </Property>    <Property Nam"+
"e=\"EnvelopeSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://dev.local/input</Value>  "+
"  </Property>    <Property Name=\"DocumentSpecNames\">      <Value xsi:type=\"xsd:string\">PlayWithBizTa"+
"lk.Recall</Value>    </Property>    <Property Name=\"DocumentSpecTargetNamespaces\">      <Value xsi:t"+
"ype=\"xsd:string\">http://dev.local/recall</Value>    </Property>    <Property Name=\"AllowUnrecognized"+
"Message\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Validat"+
"eDocument\">      <Value xsi:type=\"xsd:boolean\">false</Value>    </Property>    <Property Name=\"Recov"+
"erableInterchangeProcessing\">      <Value xsi:type=\"xsd:boolean\">true</Value>    </Property>    <Pro"+
"perty Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">EnvelopeSpecTargetNamespaces,Docume"+
"ntSpecTargetNamespaces</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp0XmlProperties);;
                ((IPersistPropertyBag)(comp0)).Load(pb, 0);
            }
            this.AddComponent(stage, comp0);
            stage = this.AddStage(new System.Guid("9d0e410d-4cce-4536-83fa-4a5040674ad6"), Microsoft.BizTalk.PipelineOM.ExecutionMode.all);
            IBaseComponent comp1 = Microsoft.BizTalk.PipelineOM.PipelineManager.CreateComponent("Microsoft.BizTalk.Component.XmlValidator,Microsoft.BizTalk.Pipeline.Components, Version=3.0.1.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35");;
            if (comp1 is IPersistPropertyBag)
            {
                string comp1XmlProperties = "<?xml version=\"1.0\" encoding=\"utf-16\"?><PropertyBag xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-inst"+
"ance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">  <Properties>    <Property Name=\"DocumentSpecNam"+
"e\">      <Value xsi:type=\"xsd:string\">PlayWithBizTalk.Recall</Value>    </Property>    <Property Nam"+
"e=\"DocumentSpecTargetNamespaces\">      <Value xsi:type=\"xsd:string\">http://dev.local/recall</Value> "+
"   </Property>    <Property Name=\"HiddenProperties\">      <Value xsi:type=\"xsd:string\">DocumentSpecT"+
"argetNamespaces</Value>    </Property>    <Property Name=\"RecoverableInterchangeProcessing\">      <V"+
"alue xsi:type=\"xsd:boolean\">false</Value>    </Property>  </Properties></PropertyBag>";
                PropertyBag pb = PropertyBag.DeserializeFromXml(comp1XmlProperties);;
                ((IPersistPropertyBag)(comp1)).Load(pb, 0);
            }
            this.AddComponent(stage, comp1);
        }
        
        public override string XmlContent
        {
            get
            {
                return _strPipeline;
            }
        }
        
        public override System.Guid VersionDependentGuid
        {
            get
            {
                return new System.Guid(_versionDependentGuid);
            }
        }
    }
}
