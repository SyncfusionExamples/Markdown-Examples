**\[MS\-CUSTOMUI]:** 

**Custom UI XML Markup Specification**


Intellectual Property Rights Notice for Open Specifications Documentation


- **Technical Documentation.** Microsoft publishes Open Specifications documentation (“this documentation”) for protocols, file formats, data portability, computer languages, and standards support. Additionally, overview documents cover inter\-protocol relationships and interactions. 

- **Copyrights**. This documentation is covered by Microsoft copyrights. Regardless of any other terms that are contained in the terms of use for the Microsoft website that hosts this documentation, you can make copies of it in order to develop implementations of the technologies that are described in this documentation and can distribute portions of it in your implementations that use these technologies or in your documentation as necessary to properly document the implementation. You can also distribute in your implementation, with or without modification, any schemas, IDLs, or code samples that are included in the documentation. This permission also applies to any documents that are referenced in the Open Specifications documentation. 

- **No Trade Secrets**. Microsoft does not claim any trade secret rights in this documentation. 

- **Patents**. Microsoft has patents that might cover your implementations of the technologies described in the Open Specifications documentation. Neither this notice nor Microsoft's delivery of this documentation grants any licenses under those patents or any other Microsoft patents. However, a given Open Specifications document might be covered by the Microsoft [Open Specifications Promise](http://go.microsoft.com/fwlink/?LinkId=214445) or the [Microsoft Community Promise](http://go.microsoft.com/fwlink/?LinkId=214448). If you would prefer a written license, or if the technologies described in this documentation are not covered by the Open Specifications Promise or Community Promise, as applicable, patent licenses are available by contacting [iplg@microsoft.com](mailto:iplg@microsoft.com). 

- **License Programs**. To see all of the protocols in scope under a specific license program and the associated patents, visit the [Patent Map](https://msdn.microsoft.com/en-us/openspecifications/dn750984). 

- **Trademarks**. The names of companies and products contained in this documentation might be covered by trademarks or similar intellectual property rights. This notice does not grant any licenses under those rights. For a list of Microsoft trademarks, visit [www.microsoft.com/trademarks](http://www.microsoft.com/trademarks). 

- **Fictitious Names**. The example companies, organizations, products, domain names, email addresses, logos, people, places, and events that are depicted in this documentation are fictitious. No association with any real company, organization, product, domain name, email address, logo, person, place, or event is intended or should be inferred.

**Reservation of Rights**. All other rights are reserved, and this notice does not grant any rights other than as specifically described above, whether by implication, estoppel, or otherwise. 

**Tools**. The Open Specifications documentation does not require the use of Microsoft programming tools or programming environments in order for you to develop an implementation. If you have access to Microsoft programming tools and environments, you are free to take advantage of them. Certain Open Specifications documents are intended for use in conjunction with publicly available standards specifications and network programming art and, as such, assume that the reader either is familiar with the aforementioned material or has immediate access to it.

**Support.** For questions and support, please contact [dochelp@microsoft.com](mailto:dochelp@microsoft.com). 

**Preliminary Documentation.** This particular Open Specifications document provides documentation for past and current releases and/or for the pre\-release version of this technology. This document provides final documentation for past and current releases and preliminary documentation, as applicable and specifically noted in this document, for the pre\-release version. Microsoft will release  \<item id\="item4" image\="Tree" /\>

\</gallery\>

The following table summarizes the elements that are parents of this element.

The following table summarizes the child elements of this element.

The following table summarizes the attributes of this element.

The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Gallery"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_GalleryRegular"\>

   \<xsd:attributeGroup ref\="AG_SizeAttributes"/\>

   \</xsd:extension\>

   \</xsd:complexContent\>

This element specifies the quick access toolbar. If the containing Custom UI file is a Ribbon Extensibility part the **qat** element cannot be used unless the **startFromScratch** attribute on the ribbon element is set to "true". In this case only the **sharedControls** child element SHOULD be used.  If the containing Custom UI file is a Quick Access Toolbar Customizations part, the **documentControls** child element SHOULD be used.

For example, consider the following controls on the document\-specific quick access toolbar:

![Controls on the quick access toolbar](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img1.png)

**Figure  SEQ Figure \\\* ARABIC 20: Controls on the quick access toolbar**

This is specified using the following XML fragment:

\<qat\>

  \<documentControls\>

    \<control idMso\="CalculateNow" /\>

    \<control idMso\="HyperlinkInsert" /\>

  \</documentControls\>

\</qat\>

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**ribbon** (section [2.2.33]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**documentControls** (List of Document\-Specific Quick Access Toolbar Controls)|[2.2.16]()|
|**sharedControls** (List of Shared Quick Access Toolbar Controls)|[2.2.35]()|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Qat"\>

   \<xsd:sequence\>

   \<xsd:element name\="sharedControls" type\="CT_QatItems" minOccurs\="0"/\>

   \<xsd:element name\="documentControls" type\="CT_QatItems" minOccurs\="0"/\>

   \</xsd:sequence\>

\</xsd:complexType\>

### **ribbon (Ribbon) XE "Elements:ribbon (ribbon)"** 

This element is used to reference the Ribbon of the application and its contents.

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**customUI** (section [2.2.14]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**contextualTabs** (List of Contextual Tab Sets)|[2.2.10]()|
|**officeMenu** (Office Menu)|[2.2.31]()|
|**qat** (Quick Access Toolbar)|[2.2.32]()|
|**tabs** (List of Tabs)|[2.2.40]()|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**startFromScratch** (start from scratch)|Specifies that the application's built\-in ribbon UI is reduced to a minimal set of features, providing a clean slate on which to build custom UI. If this attribute is omitted, its value SHOULD default to "false". For example, consider the following XML fragment:  \<ribbon startFromScratch\="true"\>   … \</ribbon\> In this example, the application's ribbon is put into start from scratch mode. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Ribbon"\>

   \<xsd:all\>

   \<xsd:element name\="officeMenu" type\="CT_OfficeMenu" minOccurs\="0" maxOccurs\="1"/\>

   \<xsd:element name\="qat" type\="CT_Qat" minOccurs\="0" maxOccurs\="1"\>

   \<xsd:unique name\="qatControls"\>

   \<xsd:selector xpath\="\*/\*"/\>

   \<xsd:field xpath\="@id"/\>

   \</xsd:unique\>

   \</xsd:element\>

   \<xsd:element name\="tabs" type\="CT_Tabs" minOccurs\="0" maxOccurs\="1"/\>

   \<xsd:element name\="contextualTabs" type\="CT_ContextualTabs" minOccurs\="0" maxOccurs\="1"/\>

   \</xsd:all\>

   \<xsd:attribute name\="startFromScratch" type\="xsd:boolean" use\="optional"/\>

\</xsd:complexType\>

### **separator (Separator) XE "Elements:separator (separator)"** 

This element specifies a vertical separator line between two sets of controls, either in the Quick Access Toolbar or within **group** elements.

For example, consider a vertical separator control between two buttons, as follows:

![A vertical separator control](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img2.png)

**Figure  SEQ Figure \\\* ARABIC 21: A vertical separator control**

This is specified using the following XML fragment:

\<button id\="button1" label\="Button 1" imageMso\="HappyFace" size\="large" /\>

\<separator id\="separator" /\>

\<button id\="button2" label\="Button 2" imageMso\="HappyFace" size\="large" /\>

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**documentControls** (section [2.2.16]()); **group** (section [2.2.23]()); **sharedControls** (section [2.2.35]())|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**getVisible** ( **getVisible** callback)|Specifies the name of a callback function to be called to determine the visibility state of this control. The **getVisible** and **visible** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible. For example, consider the following XML fragment: \<button id\="button" getVisible\="IsButtonVisible" /\> In this example, the **IsButtonVisible** callback function is called when the application needs to determine the visibility of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section [2.3.2]().|
|**id** (control identifier)|Specifies the identifier for a custom control. All custom controls MUST have unique identifiers. The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call. The **id** and **idQ** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<button id\="MyButton" label\="Button" /\> This specifies a custom button control with an identifier of "MyButton". The possible values for this attribute are defined by the **ST_UniqueID** simple type, as specified in section [2.3.13]().|
|**idQ** (qualified control identifier)|Specifies a qualified identifier for a control. The **idQ** attribute can be used to reference controls or containers created by other Custom UI documents. The **id** and **idQ** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<customUI    xmlns\="http://schemas.microsoft.com/office/2006/01/customui"   xmlns:ex\="http://www.example.com"\>   \<ribbon\>     \<tabs\>      \<tab idQ\="ex:OtherTab" label\="Shared Tab"\>         \<group id\="MyGroup" label\="My Group"\>           …         \</group\>       \</tab\>     \</tabs\>   \</ribbon\> \</customUI\> In this case, **ex** is an XML namespace prefix for the namespace http://www.example.com. This XML fragment refers to a **tab** in that namespace with an identifier of "OtherTab". If that tab cannot be found, it is created. A new group belonging to this file is added to the tab. The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section [2.3.9]().|
|**insertAfterMso** (identifier of built\-in control to insert after)|Specifies the identifier of a built\-in control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section [2.3.5]().|
|**insertAfterQ** (qualified identifier of control to insert after)|Specifies the qualified identifier of a control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**insertBeforeMso** (identifier of built\-in control to insert before)|Specifies the identifier of a built\-in control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertBeforeQ** (qualified identifier of control to insert before)|Specifies the qualified identifier of a control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**visible** (control visibility)|Specifies the visibility state of the control. The **getVisible** and **visible** attributes are mutually exclusive. If these attributes are omitted, the control SHOULD default to being visible. For example, consider the following XML fragment: \<tab idMso\="TabHome" visible\="false" /\> In this example, the built\-in tab with an identifier of "TabHome" is hidden. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Separator"\>

   \<xsd:attributeGroup ref\="AG_IDCustom"/\>

   \<xsd:attributeGroup ref\="AG_Visible"/\>

   \<xsd:attributeGroup ref\="AG_PositionAttributes"/\>

\</xsd:complexType\>

### **sharedControls (List of Shared Quick Access Toolbar Controls) XE "Elements:sharedControls (list of shared Quick Access Toolbar controls)"** 

This element specifies the section of the quick access toolbar that is shared among all documents. This element SHOULD NOT be specified if the containing Custom UI XML document is a Quick Access Toolbar Customizations part. If the containing Custom UI XML document is a Ribbon Extensibility part, this element can be used if the **startFromScratch** attribute is set to "true" on the ribbon element.

For example, consider a Ribbon Extensibility XML document that adds the two buttons to the shared section of the quick access toolbar:

![Shared controls on the quick access toolbar](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img3.png)

**Figure  SEQ Figure \\\* ARABIC 22: Shared controls on the quick access toolbar**

This is specified using the following XML fragment:

\<qat\>

 \<sharedControls\>

  \<button id\="button1" imageMso\="HappyFace" /\>

  \<button idMso\="Cut" /\>

 \</sharedControls\>

\</qat\>

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**qat** (section [2.2.32]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**button** (Unsized Button)|[2.2.3]()|
|**control** (Quick Access Toolbar Control Clone)|[2.2.13]()|
|**separator** (Separator)|[2.2.34]()|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_QatItems"\>

   \<xsd:sequence\>

   \<xsd:choice minOccurs\="0" maxOccurs\="1000"\>

   \<xsd:element name\="control" type\="CT_ControlCloneQat"/\>

   \<xsd:element name\="button" type\="CT_ButtonRegular"/\>

   \<xsd:element name\="separator" type\="CT_Separator"/\>

   \</xsd:choice\>

   \</xsd:sequence\>

\</xsd:complexType\>

### **splitButton (Unsized Split Button) XE "Elements:splitButton (unsized split button)"** 

This element specifies a split button control that, because of its location, cannot have its size changed. The **size** attribute is not present. It otherwise behaves identically to the regular **splitButton** element, as specified in section [2.2.38]().

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**buttonGroup** (section [2.2.5]()); **menu** (section [2.2.28]()); **menu** (section [2.2.26]()); **menu** (section [2.2.29]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**button** (Button Inside of a Split Button)|[2.2.4]()|
|**menu** (Unsized Menu)|2.2.26|
|**toggleButton** (Toggle Button Inside of a Split Button)|[2.2.44]()|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**enabled** (enabled state)|Specifies the enabled state of the control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. This attribute cannot be used to enable a built\-in control that would otherwise be disabled by the application. For example, consider the following XML fragment: \<button id\="button" label\="Disabled Button" enabled\="false" /\> This specifies a new button that is disabled. A permanently disabled button is not very useful, thus the **enabled** attribute is not commonly used. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**getEnabled** ( **getEnabled** callback)|Specifies the name of a callback function to be called to determine the enabled state of this control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. For example, consider the following XML fragment: \<button id\="button" getEnabled\="IsButtonEnabled" /\> In this example, the **IsButtonEnabled** callback function is called when the application needs to determine the enabled state of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section [2.3.2]().|
|**getImage** ( **getImage** callback)|Specifies the name of a callback function to be called to determine the icon of this control. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getImage\="GetButtonImage" /\> In this example, the **GetButtonImage** callback function is called when the application needs to determine the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getKeytip** ( **getKeytip** callback)|Specifies the name of a callback function to be called to determine the suggested [KeyTip]() of this control. The **getKeytip** and **keytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider the following XML fragment: \<button id\="button" getKeytip\="GetButtonKeytip" /\> In this example, the **GetButtonKeytip** callback function is called when the application needs to determine the KeyTip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getLabel** ( **getLabel** callback)|Specifies the name of a callback function to be called to determine the label of this control. The **getLabel** and **label** attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getLabel\="GetButtonLabel" /\> In this example, the **GetButtonLabel** callback function is called when the application needs to determine the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getScreentip** ( **getScreentip** callback)|Specifies the name of a callback function to be called to determine the screentip of this control. The **getScreentip** and **screentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider the following XML fragment: \<button id\="button" getScreentip\="GetButtonScreentip" /\> In this example, the **GetButtonScreentip** callback function is called when the application needs to determine the screentip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowImage** ( **getShowImage** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the icon of this control.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider the following XML fragment: \<button id\="button" getShowImage\="IsButtonImageVisible" /\> In this example, the **IsButtonImageVisible** callback function is called when the application needs to determine whether to display the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowLabel** ( **getShowLabel** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the label of this control.  The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" getShowLabel\="IsButtonLabelVisible" /\> In this example, the **IsButtonLabelVisible** callback function is called when the application needs to determine whether to display the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getSupertip** ( **getSupertip** callback)|Specifies the name of a callback function to be called to determine the supertip of this control. The **getSupertip** and **supertip** attributes are mutually exclusive. If neither attribute is specified, no supertip for this control SHOULD be shown. For example, consider the following XML fragment: \<button id\="button" getSupertip\="GetButtonSupertip" /\> In this example, the **GetButtonSupertip** callback function is called when the application needs to determine the supertip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getVisible** ( **getVisible** callback)|Specifies the name of a callback function to be called to determine the visibility state of this control. The **getVisible** and **visible** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible. For example, consider the following XML fragment: \<button id\="button" getVisible\="IsButtonVisible" /\> In this example, the **IsButtonVisible** callback function is called when the application needs to determine the visibility of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**id** (control identifier)|Specifies the identifier for a custom control. All custom controls MUST have unique identifiers. The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<button id\="MyButton" label\="Button" /\> This specifies a custom button control with an identifier of "MyButton". The possible values for this attribute are defined by the **ST_UniqueID** simple type, as specified in section [2.3.13]().|
|**idMso** (built\-in control identifier)|Specifies the identifier of a built\-in control.  The contents of this attribute are application\-defined. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<control idMso\="Bold" /\> This creates a clone of the control with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section [2.3.5]().|
|**idQ** (qualified control identifier)|Specifies a qualified identifier for a control. The **idQ** attribute can be used to reference controls or containers created by other Custom UI documents. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<customUI    xmlns\="http://schemas.microsoft.com/office/2006/01/customui"   xmlns:ex\="http://www.example.com"\>   \<ribbon\>     \<tabs\>      \<tab idQ\="ex:OtherTab" label\="Shared Tab"\>         \<group id\="MyGroup" label\="My Group"\>           …         \</group\>       \</tab\>     \</tabs\>   \</ribbon\> \</customUI\> In this case, **ex** is an XML namespace prefix for the namespace http://www.example.com. This XML fragment refers to a **tab** in that namespace with an identifier of "OtherTab". If that tab cannot be found, it is created. A new group belonging to this file is added to the tab. The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section [2.3.9]().|
|**image** (custom image identifier)|Specifies the relationship identifier for an image which SHOULD be used as the icon for this control. This attribute is used to specify an embedded picture that resides locally within the containing file. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" image\="ForestPic" /\> This specifies a custom button whose icon SHOULD be the embedded image file referenced by the relationship identifier of "ForestPic". The possible values for this attribute are defined by the **ST_Uri** simple type, as specified in section [2.3.14]().|
|**imageMso** (built\-in image identifier)|Specifies the identifier of a built\-in image which SHOULD be used as the icon of this control. The contents of this attribute are application\-defined and SHOULD be ignored if not understood. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" imageMso\="Bold" /\> This specifies a custom button that SHOULD use the built\-in image with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterMso** (identifier of built\-in control to insert after)|Specifies the identifier of a built\-in control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterQ** (qualified identifier of control to insert after)|Specifies the qualified identifier of a control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**insertBeforeMso** (identifier of built\-in control to insert before)|Specifies the identifier of a built\-in control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertBeforeQ** (qualified identifier of control to insert before)|Specifies the qualified identifier of a control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**keytip** (keytip)|Specifies a **string** to be used as the suggested KeyTip for this control. The **keytip** and **getKeytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider a button with KeyTip 'K', as follows: ![Button with Key Tip K](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img4.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" keytip\="K" /\> The possible values for this attribute are defined by the **ST_Keytip** simple type, as specified in section [2.3.7]().|
|**label** (label)|Specifies a **string** to be used as the label for this control. The **label** and **getLabel** attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" label\="Custom Button" /\> This specifies a custom **button** with a **label** of "Custom Button". The possible values for this attribute are defined by the **ST_String** simple type, as specified in section [2.3.11]().|
|**screentip** (screentip)|Specifies a **string** to be shown as the screentip for this control. The **screentip** and **getScreentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider a button with a screentip, as follows: ![Button with screen tip String](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img5.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="This is the screentip" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**showImage** (show image)|Specifies whether this control displays an icon.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider a button that does not display an icon, as follows: ![Button with no icon](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img6.png) This is specified using the following XML fragment: \<button id\="button" showImage\="false"    label\="Button with no icon" /\>  The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**showLabel** (show label)|Specifies whether this control SHOULD display its label.   The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" label\="Label" showLabel\="false"    imageMso\="HappyFace" /\> This specifies a **button** that has a **label**, but does not show it. Even though the **label** is hidden, it is provided to accessibility tools. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**supertip** (supertip)|Specifies a **string** to be shown as the supertip of the control. The **supertip** and **getSupertip** attributes are mutually exclusive. If neither attribute is specified no supertip for this control SHOULD be shown. For example, consider a control with a supertip, as follows: ![Button with super stip string](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img7.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="Screentip"   supertip\="This is the supertip string" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**tag** (tag)|Specifies an arbitrary **string** that can be used to hold data or identify the control. The contents of this attribute SHOULD be passed to any callback functions specified on this control. If this attribute is omitted, the control's **tag** value SHOULD default to an empty **string**. For example, consider the following XML fragment: \<button id\="button" label\="Button" tag\="123456"    onAction\="ButtonClicked" /\> This specifies a **button** with a **tag** value of "123456", which is passed to the **ButtonClicked** callback function. The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**visible** (control visibility)|Specifies the visibility state of the control. The **getVisible** and **visible** attributes are mutually exclusive. If these attributes are omitted, the control SHOULD default to being visible. For example, consider the following XML fragment: \<tab idMso\="TabHome" visible\="false" /\> In this example, the built\-in tab with an identifier of "TabHome" is hidden. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_SplitButtonRegular"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_SplitButtonRestricted"\>

   \<xsd:sequence minOccurs\="0"\>

   \<xsd:choice minOccurs\="0"\>

   \<xsd:element name\="button" type\="CT_VisibleButton"/\>

   \<xsd:element name\="toggleButton" type\="CT_VisibleToggleButton"/\>

   \</xsd:choice\>

   \<xsd:element name\="menu" type\="CT_MenuRegular"/\>

   \</xsd:sequence\>

   \</xsd:extension\>

   \</xsd:complexContent\>

\</xsd:complexType\>

### **splitButton (Split Button with Title) XE "Elements:splitButton (split button with title)"** 

This element specifies a split button control that, because of its location, can optionally include a title string via the **title** or **getTitle** attributes. It otherwise behaves identically to the regular **splitButton** element, as specified in section [2.2.38]().

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**menu** (section [2.2.27]()); **officeMenu** (section [2.2.31]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**button** (Button Inside of a Split Button)|[2.2.4]()|
|**menu** (Menu with Title)|2.2.27|
|**toggleButton** (Toggle Button Inside of a Split Button)|[2.2.44]()|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**enabled** (enabled state)|Specifies the enabled state of the control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. This attribute cannot be used to enable a built\-in control that would otherwise be disabled by the application. For example, consider the following XML fragment: \<button id\="button" label\="Disabled Button" enabled\="false" /\> This specifies a new button that is disabled. A permanently disabled button is not very useful, thus the **enabled** attribute is not commonly used. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**getEnabled** ( **getEnabled** callback)|Specifies the name of a callback function to be called to determine the enabled state of this control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. For example, consider the following XML fragment: \<button id\="button" getEnabled\="IsButtonEnabled" /\> In this example, the **IsButtonEnabled** callback function is called when the application needs to determine the enabled state of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section [2.3.2]().|
|**getImage** ( **getImage** callback)|Specifies the name of a callback function to be called to determine the icon of this control. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getImage\="GetButtonImage" /\> In this example, the **GetButtonImage** callback function is called when the application needs to determine the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getKeytip** ( **getKeytip** callback)|Specifies the name of a callback function to be called to determine the suggested [KeyTip]() of this control. The **getKeytip** and **keytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider the following XML fragment: \<button id\="button" getKeytip\="GetButtonKeytip" /\> In this example, the **GetButtonKeytip** callback function is called when the application needs to determine the KeyTip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getLabel** ( **getLabel** callback)|Specifies the name of a callback function to be called to determine the label of this control. The **getLabel** and **label** attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getLabel\="GetButtonLabel" /\> In this example, the **GetButtonLabel** callback function is called when the application needs to determine the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getScreentip** ( **getScreentip** callback)|Specifies the name of a callback function to be called to determine the screentip of this control. The **getScreentip** and **screentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider the following XML fragment: \<button id\="button" getScreentip\="GetButtonScreentip" /\> In this example, the **GetButtonScreentip** callback function is called when the application needs to determine the screentip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowImage** ( **getShowImage** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the icon of this control.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider the following XML fragment: \<button id\="button" getShowImage\="IsButtonImageVisible" /\> In this example, the **IsButtonImageVisible** callback function is called when the application needs to determine whether to display the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowLabel** ( **getShowLabel** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the label of this control.  The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" getShowLabel\="IsButtonLabelVisible" /\> In this example, the **IsButtonLabelVisible** callback function is called when the application needs to determine whether to display the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getSupertip** ( **getSupertip** callback)|Specifies the name of a callback function to be called to determine the supertip of this control. The **getSupertip** and **supertip** attributes are mutually exclusive. If neither attribute is specified, no supertip for this control SHOULD be shown. For example, consider the following XML fragment: \<button id\="button" getSupertip\="GetButtonSupertip" /\> In this example, the **GetButtonSupertip** callback function is called when the application needs to determine the supertip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getVisible** ( **getVisible** callback)|Specifies the name of a callback function to be called to determine the visibility state of this control. The **getVisible** and **visible** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible. For example, consider the following XML fragment: \<button id\="button" getVisible\="IsButtonVisible" /\> In this example, the **IsButtonVisible** callback function is called when the application needs to determine the visibility of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**id** (control identifier)|Specifies the identifier for a custom control. All custom controls MUST have unique identifiers. The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<button id\="MyButton" label\="Button" /\> This specifies a custom button control with an identifier of "MyButton". The possible values for this attribute are defined by the **ST_UniqueID** simple type, as specified in section [2.3.13]().|
|**idMso** (built\-in control identifier)|Specifies the identifier of a built\-in control.  The contents of this attribute are application\-defined. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<control idMso\="Bold" /\> This creates a clone of the control with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section [2.3.5]().|
|**idQ** (qualified control identifier)|Specifies a qualified identifier for a control. The **idQ** attribute can be used to reference controls or containers created by other Custom UI documents. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<customUI    xmlns\="http://schemas.microsoft.com/office/2006/01/customui"   xmlns:ex\="http://www.example.com"\>   \<ribbon\>     \<tabs\>      \<tab idQ\="ex:OtherTab" label\="Shared Tab"\>         \<group id\="MyGroup" label\="My Group"\>           …         \</group\>       \</tab\>     \</tabs\>   \</ribbon\> \</customUI\> In this case, **ex** is an XML namespace prefix for the namespace http://www.example.com. This XML fragment refers to a **tab** in that namespace with an identifier of "OtherTab". If that tab cannot be found, it is created. A new group belonging to this file is added to the tab. The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section [2.3.9]().|
|**image** (custom image identifier)|Specifies the relationship identifier for an image which SHOULD be used as the icon for this control. This attribute is used to specify an embedded picture that resides locally within the containing file. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" image\="ForestPic" /\> This specifies a custom button whose icon SHOULD be the embedded image file referenced by the relationship identifier of "ForestPic". The possible values for this attribute are defined by the **ST_Uri** simple type, as specified in section [2.3.14]().|
|**imageMso** (built\-in image identifier)|Specifies the identifier of a built\-in image which SHOULD be used as the icon of this control. The contents of this attribute are application\-defined and SHOULD be ignored if not understood. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" imageMso\="Bold" /\> This specifies a custom button that SHOULD use the built\-in image with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterMso** (identifier of built\-in control to insert after)|Specifies the identifier of a built\-in control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterQ** (qualified identifier of control to insert after)|Specifies the qualified identifier of a control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**insertBeforeMso** (identifier of built\-in control to insert before)|Specifies the identifier of a built\-in control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertBeforeQ** (qualified identifier of control to insert before)|Specifies the qualified identifier of a control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**keytip** (keytip)|Specifies a **string** to be used as the suggested KeyTip for this control. The **keytip** and **getKeytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider a button with KeyTip 'K', as follows: ![Button with Key Tip K](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img8.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" keytip\="K" /\> The possible values for this attribute are defined by the **ST_Keytip** simple type, as specified in section [2.3.7]().|
|**label** (label)|Specifies a **string** to be used as the label for this control. The **label** and **getLabel** attributes are mutually exclusive. If neither attribute is specified, no **label** SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" label\="Custom Button" /\> This specifies a custom **button** with a **label** of "Custom Button". The possible values for this attribute are defined by the **ST_String** simple type, as specified in section [2.3.11]().|
|**screentip** (screentip)|Specifies a **string** to be shown as the screentip for this control. The **screentip** and **getScreentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider a button with a screentip, as follows: ![Button with screen tip string](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img9.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="This is the screentip" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**showImage** (show image)|Specifies whether this control displays an icon.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider a button that does not display an icon, as follows: ![Button with no icon](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img10.png) This is specified using the following XML fragment: \<button id\="button" showImage\="false"    label\="Button with no icon" /\>  The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**showLabel** (show label)|Specifies whether this control SHOULD display its label.   The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" label\="Label" showLabel\="false"    imageMso\="HappyFace" /\> This specifies a **button** that has a **label**, but does not show it. Even though the **label** is hidden, it is provided to accessibility tools. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**supertip** (supertip)|Specifies a **string** to be shown as the supertip of the control. The **supertip** and **getSupertip** attributes are mutually exclusive. If neither attribute is specified no supertip for this control SHOULD be shown. For example, consider a control with a supertip, as follows: ![Button with super tip string](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img11.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="Screentip"   supertip\="This is the supertip string" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**tag** (tag)|Specifies an arbitrary **string** that can be used to hold data or identify the control. The contents of this attribute SHOULD be passed to any callback functions specified on this control. If this attribute is omitted, the control's **tag** value SHOULD default to an empty **string**. For example, consider the following XML fragment: \<button id\="button" label\="Button" tag\="123456"    onAction\="ButtonClicked" /\> This specifies a **button** with a **tag** value of "123456", which is passed to the **ButtonClicked** callback function. The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**visible** (control visibility)|Specifies the visibility state of the control. The **getVisible** and **visible** attributes are mutually exclusive. If these attributes are omitted, the control SHOULD default to being visible. For example, consider the following XML fragment: \<tab idMso\="TabHome" visible\="false" /\> In this example, the built\-in tab with an identifier of "TabHome" is hidden. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_SplitButtonWithTitle"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_SplitButtonRestricted"\>

   \<xsd:sequence minOccurs\="0"\>

   \<xsd:choice minOccurs\="0"\>

   \<xsd:element name\="button" type\="CT_VisibleButton"/\>

   \<xsd:element name\="toggleButton" type\="CT_VisibleToggleButton"/\>

   \</xsd:choice\>

   \<xsd:element name\="menu" type\="CT_MenuWithTitle"/\>

   \</xsd:sequence\>

   \</xsd:extension\>

   \</xsd:complexContent\>

\</xsd:complexType\>

The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_ToggleButton"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_ToggleButtonRegular"\>

   \<xsd:attributeGroup ref\="AG_SizeAttributes"/\>

   \</xsd:extension\>

   \</xsd:complexContent\>


### **Excel 2007 XE "idMso tables:Excel 2007"  XE "Tables:idMso table – Excel 2007"** 
|**Control Type**|**Label**|
|:---|:---|
|button|Spelling...|
|button|Save|
|button|Print|
|button|Chart...|
|button|New|
|button|Copy|
|button|Cut|
|button|Paste|
|button|Open|
|toggleButton|Zoom|
|button|Repeat|
|toggleButton|Double Underline|
|button|Close|
|toggleButton|Format Painter|
|button|Print Preview|
|toggleButton|Bold|
|toggleButton|Italic|
|toggleButton|Underline|
|button|Dark Shading|
|toggleButton|Align Left|
|toggleButton|Align Right|
|toggleButton|Center|
|toggleButton|Justify|
|gallery|Undo|
|gallery|Redo|
|toggleButton|Top Border|
|toggleButton|Bottom Border|
|toggleButton|Left Border|
|toggleButton|Right Border|
|button|Inside Borders|
|button|Outside Borders|
|button|No Border|
|button|Group|
|button|Ungroup|
|button|Bring to Front|
|button|Send to Back|
|button|Bring Forward|
|button|Send Backward|
|toggleButton|Full Screen|
|toggleButton|Select Objects|
|button|Record Macro...|
|button|Macros|
|button|Flip Horizontal|
|button|Flip Vertical|
|button|Rotate Right 90°|
|button|Rotate Left 90°|
|toggleButton|Freeform|
|toggleButton|Edit Points|
|button|Edit Box|
|button|Check Box|
|button|Combo Box|
|button|Property Sheet|
|toggleButton|Lock|
|button|Sum|
|button|Edit Cell Styles|
|button|Camera|
|button|Button|
|button|Calculator|
|toggleButton|Strikethrough|
|button|Delete Cells...|
|button|Insert Cells...|
|button|Arrange All|
|button|New Window|
|button|Accept/Reject Changes|
|button|Symbol...|
|button|Replace...|
|button|Previous Page|
|button|Next Page|
|toggleButton|Vertical Text Box|
|button|Regroup|
|button|Set Print Area|
|button|Paste Formatting|
|button|Paste Values|
|button|Right|
|button|Down|
|button|Equal Sign|
|button|Plus Sign|
|button|Minus Sign|
|button|Multiplication Sign|
|button|Division Sign|
|button|Exponentiation Sign|
|button|Left Parenthesis|
|button|Right Parenthesis|
|button|Colon|
|button|Comma|
|button|Percent Sign|
|button|Dollar Sign|
|button|Insert Function...|
|button|Constrain Numeric|
|button|Light Shading|
|button|Accounting Number Format|
|button|Percent Style|
|button|Comma Style|
|button|Increase Decimal|
|button|Decrease Decimal|
|toggleButton|Merge \& Center|
|button|Increase Font Size|
|button|Decrease Font Size|
|toggleButton|Vertical Text|
|toggleButton|Rotate Text Up|
|toggleButton|Rotate Text Down|
|button|Distribute Horizontally|
|toggleButton|Scribble|
|button|Show Outline Symbols|
|button|Select Visible Cells|
|button|Select Current Region|
|button|Freeze Panes|
|button|Zoom In|
|button|Zoom Out|
|button|Option Button|
|button|Scroll Bar|
|button|List Box|
|button|Remove Dependent Arrows|
|button|Trace Dependents|
|button|Remove Precedent Arrows|
|button|Remove Arrows|
|button|Update File|
|button|Toggle Read Only|
|button|AutoFilter|
|button|Refresh|
|button|Field Settings|
|button|Show Report Filter Pages...|
|button|Show Detail|
|button|Trace Error|
|button|Hide Detail|
|button|Distribute Vertically|
|button|Group Box|
|button|Spinner|
|button|Tab Order...|
|button|Run Dialog|
|button|Combination List\-Edit|
|button|Combination Drop\-Down Edit|
|button|Label|
|button|Trace Precedents|
|button|Code|
|button|Insert Page Break|
|button|Parameters|
|button|Row Height...|
|button|Column Width...|
|button|Object...|
|toggleButton|Snap to Grid|
|button|Align Left|
|button|Align Right|
|button|Align Top|
|button|Align Bottom|
|button|Align Center|
|button|Align Middle|
|toggleButton|Clip Art...|
|button|Free Rotate|
|toggleButton|Yoko\-Gumi|
|toggleButton|Normal|
|toggleButton|Page Break Preview|
|toggleButton|Crop|
|button|Close All|
|button|Save As|
|button|View Document Properties...|
|button|Copy as Picture...|
|button|Paste Special...|
|button|Select All|
|button|Go To...|
|button|Edit Links to Files|
|button|Header \& Footer...|
|button|Bullets and Numbering...|
|button|AutoFormat...|
|button|Merge Cells|
|button|Split Cells...|
|button|Convert Text to Table...|
|button|Office Clipboard...|
|button|Create Microsoft Office Outlook Task|
|button|Minimize|
|button|Restore|
|button|Close|
|button|Save Workspace...|
|button|Delete Sheet|
|button|Move or Copy Sheet...|
|checkBox|Formula Bar|
|button|Insert Sheet|
|button|Format Cells...|
|button|Goal Seek...|
|button|Scenario Manager...|
|button|Form...|
|button|Subtotal|
|button|Data Table...|
|button|Consolidate...|
|button|Hide|
|button|Unhide...|
|button|Up|
|button|Left|
|button|Across Worksheets...|
|button|Series...|
|button|Justify|
|button|Clear Formats|
|button|Clear Contents|
|button|Clear Comments|
|button|Paste Names...|
|button|Create from Selection...|
|button|Apply Names...|
|button|AutoFit Row Height|
|button|Hide Rows|
|button|Unhide Rows|
|button|AutoFit Column Width|
|button|Hide Columns|
|button|Unhide Columns|
|button|Default Width...|
|button|Clear|
|toggleButton|Superscript|
|toggleButton|Subscript|
|button|Close|
|toggleButton|Format Painter|
|toggleButton|Print Preview|
|button|Pick Up Style|
|button|Apply Style|
|toggleButton|Bold|
|toggleButton|Italic|
|toggleButton|Underline|
|toggleButton|Align Left|
|toggleButton|Align Right|
|toggleButton|Center|
|toggleButton|Justify|
|gallery|Undo|
|gallery|Redo|
|button|Promote|
|button|Demote|
|button|Move Up|
|button|Move Down|
|button|Expand|
|button|Collapse|
|toggleButton|Text Box|
|button|Find...|
|toggleButton|Top Border|
|toggleButton|Bottom Border|
|toggleButton|Left Border|
|toggleButton|Right Border|
|toggleButton|Inside Borders|
|toggleButton|Outside Borders|
|toggleButton|No Border|
|button|Group|
|button|Ungroup|
|button|Bring to Front|
|button|Send to Back|
|button|Bring Forward|
|button|Send Backward|
|button|Full Screen|
|checkBox|Ruler|
|toggleButton|Select Objects|
|button|Macros|
|button|Flip Horizontal|
|button|Flip Vertical|
|button|Rotate Right 90°|
|button|Rotate Left 90°|
|group|Drawing|
|toggleButton|Edit Points|
|button|Grid Settings...|
|button|Property Sheet|
|toggleButton|Show Text Formatting|
|toggleButton|Strikethrough|
|button|Arrange All|
|button|New Window|
|button|Symbol...|
|button|Replace...|
|button|Previous Page|
|button|Next Page|
|toggleButton|Vertical Text Box|
|button|Redo|
|button|Regroup|
|button|Increase Font Size|
|button|Decrease Font Size|
|button|Object...|
|toggleButton|Snap to Grid|
|button|Find Next|
|button|Duplicate|
|button|New Slide|
|toggleButton|Clip Art...|
|button|Create Handouts in Microsoft Office Word|
|toggleButton|Shadow|
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|button|Tab|
|button|Cascade|
|toggleButton|Inside Horizontal Border|
|toggleButton|Inside Vertical Border|
|toggleButton|Diagonal Down Border|
|toggleButton|Diagonal Up Border|
|toggleButton|Left\-to\-Right|
|toggleButton|Right\-to\-Left|
|button|Check Box|
|button|Text Box|
|button|Command Button|
|button|Option Button|
|button|List Box|
|button|Combo Box|
|button|Toggle Button|
|button|Spin Button|
|button|Scroll Bar|
|button|Label|
|button|Convert...|
|button|Edit Comment|
|toggleButton|Draw Table|
|toggleButton|Eraser|
|toggleButton|Align Top|
|toggleButton|Center Vertically|
|toggleButton|Align Bottom|
|button|Distribute Columns|
|button|Distribute Rows|
|button|Image|
|button|Delete Rows|
|button|Delete Columns|
|button|Shadow On/Off|
|button|Set AutoShape Defaults|
|button|E\-mail|
|button|New|
|button|Quick Print|
|button|Picture...|
|dropDown|Pen Weight|
|toggleButton|View Gridlines|
|gallery|Pen Color|
|toggleButton|Straight Arrow Connector|
|toggleButton|Elbow Arrow Connector|
|button|Delete|
|toggleButton|Handout Master|
|toggleButton|Notes Master|
|toggleButton|Reuse Slides...|
|button|Slides from Outline...|
|button|Movie from Organizer...|
|button|Movie from File...|
|button|Sound from Clip Organizer...|
|button|Sound from File...|
|button|Play CD Audio Track...|
|button|Replace Fonts...|
|button|Toggle Case|
|toggleButton|B \& W Automatic|
|toggleButton|B \& W|
|toggleButton|B \& W Black with Grayscale Fill|
|toggleButton|B \& W Black with White Fill|
|toggleButton|B \& W Don't Show|
|toggleButton|B \& W Gray with White Fill|
|toggleButton|B \& W Grayscale|
|toggleButton|B \& W Inverse Grayscale|
|toggleButton|B \& W White|
|toggleButton|B \& W Light Grayscale|
|button|Record Narration|
|button|Set Up Slide Show...|
|button|Paste as Hyperlink|
|toggleButton|Distributed|
|button|Reset Character Formatting|
|toggleButton|Set Transparent Color|
|button|Custom Slide Show|
|button|Fit to Page|
|button|Record Sound...|
|button|Duplicate Selected Slides|
|button|Action|
|button|Previous|
|button|Next|
|button|Break Link|
|button|Change Link|
|button|Update Links|
|button|Lower Baseline|
|button|Raise Baseline|
|button|Slide Show in a Window|
|button|Hangul Hanja Conversion|
|toggleButton|2 Slides|
|toggleButton|3 Slides|
|toggleButton|6 Slides|
|toggleButton|Slide Outline|
|button|Go To...|
|button|Increase Indent|
|button|Decrease Indent|
|button|Preview|
|toggleButton|4 Slides|
|toggleButton|9 Slides|
|button|Macro Security|
|button|Web Page Preview|
|button|Table...|
|button|Insert Above|
|button|Insert Below|
|button|Insert Left|
|button|Insert Right|
|button|COM Add\-Ins...|
|toggleButton|Normal|
|button|Web Options...|
|toggleButton|Left\-to\-Right|
|toggleButton|Right\-to\-Left|
|button|Next Pane|
|button|Move Split|
|toggleButton|Set Left\-to\-Right Table|
|toggleButton|Set Right\-to\-Left Table|
|button|Resume Slide Show|
|button|Select Multiple Objects|
|button|More Colors...|
|button|Fit|
|button|Resize|
|toggleButton|Back To Color View|
|toggleButton|Grayscale|
|toggleButton|High Contrast|
|toggleButton|Pure Black and White|
|dropDown|Print What|
|button|Expand|
|toggleButton|1 Slide|
|toggleButton|Preserve|
|button|Rename|
|button|Show Outline|
|button|Bullets and Numbering...|
|button|Check Out|
|button|Check In|
|toggleButton|Landscape|
|toggleButton|Portrait|
|button|Reset|
|button|Compress Pictures...|
|button|Delete|
|button|Next|
|button|Previous|
|toggleButton|Show Markup|
|button|Delete All Markup on the Current Slide|
|button|Translate...|
|checkBox|View Gridlines|
|button|New Photo Album...|
|button|Edit Photo Album...|
|button|Scale Drawing|
|toggleButton|Research...|
|button|Internet Fax|
|button|Package for CD|
|button|View Version History|
|button|More Ink Colors...|
|button|Contact Us...|
|toggleButton|Unrestricted Access|
|toggleButton|Restricted Access|
|button|View Permission|
|button|Thesaurus...|
|button|Start Inking|
|button|Check for Updates|
|toggleButton|Eraser|
|button|Manage Credentials|
|button|Browse for Themes...|
|button|Insert Layout|
|toggleButton|View Signatures|
|button|View Workflow Tasks|
|button|Workflows|
|gallery|Themes|
|button|Label|
|button|Barcode|
|gallery|Quick Styles|
|gallery|Quick Layout|
|button|Save As Template|
|menu|Axis Titles|
|menu|Axes|
|menu|Gridlines|
|button|Format Selection|
|comboBox|Chart Elements|
|button|From Current Slide|
|gallery|Bullets|
|gallery|Numbering|
|gallery|Line Spacing|
|gallery|New Slide|
|gallery|Layout|
|tab|Format|
|tab|Format|
|gallery|Shapes|
|gallery|Change Shape|
|gallery|Texture|
|gallery|Quick Styles|
|menu|Orientation|
|menu|Server|
|menu|Send|
|tab|Insert|
|tab|View|
|group|Font|
|group|Paragraph|
|group|Proofing|
|group|Illustrations|
|group|Insert Shapes|
|group|Page Setup|
|group|Comments|
|group|Size|
|group|Draw Borders|
|tab|Design|
|tab|Animations|
|tab|Slide Show|
|group|Slides|
|group|Arrange|
|group|Media Clips|
|group|Themes|
|group|Background|
|group|Preview|
|group|Animations|
|group|Transition to This Slide|
|group|Start Slide Show|
|group|Set Up|
|group|Shape Styles|
|tab|Review|
|group|Chart Layouts|
|group|Chart Styles|
|group|Axes|
|group|Insert|
|gallery|Preset|
|gallery|Preset|
|gallery|3\-D Rotation|
|tab|Design|
|tab|Format|
|tab|Design|
|tab|Layout|
|tab|Format|
|gallery|Shape Fill|
|gallery|Picture Border|
|button|Inspect Document|
|button|Clear Formatting|
|group|Controls|
|group|Zoom|
|button|Publish Slides|
|checkBox|Use Presenter View|
|gallery|Arrows|
|gallery|Dashes|
|gallery|Weight|
|tab|Layout|
|group|Alignment|
|group|Adjust|
|group|Size|
|tab|Slide Master|
|group|Table Styles|
|group|Rows \& Columns|
|menu|Align|
|splitButton|Movie|
|splitButton|Sound|
|gallery|Rotate|
|menu|Select|
|dropDown|Animate:|
|gallery|Transition Scheme|
|dropDown|Transition Speed:|
|gallery|Font Color|
|gallery|Columns|
|tab|Home|
|gallery|Chart Title|
|gallery|Primary Horizontal Axis Title|
|gallery|Primary Vertical Axis Title|
|gallery|Depth Axis Title|
|gallery|Legend|
|gallery|Data Labels|
|gallery|Primary Horizontal Gridlines|
|gallery|Primary Vertical Gridlines|
|gallery|Depth Gridlines|
|gallery|Primary Horizontal Axis|
|gallery|Primary Vertical Axis|
|gallery|Depth Axis|
|gallery|Data Table|
|gallery|Trendline|
|gallery|Error Bars|
|gallery|Lines|
|gallery|Up/Down Bars|
|gallery|Plot Area|
|gallery|Chart Wall|
|gallery|Chart Floor|
|button|Add Shape|
|button|Larger|
|button|Smaller|
|button|Reset Graphic|
|toggleButton|Text Pane|
|toggleButton|Edit in 2\-D|
|gallery|Change Layout|
|button|More Layouts...|
|gallery|Quick Styles|
|gallery|Change Colors|
|gallery|Soft Edges|
|gallery|Glow|
|gallery|Gradient|
|gallery|Shadow|
|gallery|WordArt|
|gallery|Transform|
|gallery|Colors|
|group|Layouts|
|group|SmartArt Styles|
|group|Create Graphic|
|group|Reset|
|group|Size|
|button|More Themes on Microsoft Office Online...|
|tab|Add\-Ins|
|menu|Edit Shape|
|button|Content|
|button|Text|
|button|Chart|
|button|Table|
|button|SmartArt|
|button|Media|
|button|Clip Art|
|button|Text |
|checkBox|Title|
|checkBox|Footers|
|gallery|Table Styles|
|button|Publish as PDF or XPS|
|button|OpenDocument Presentation|
|button|More Controls...|
|group|Code|
|tab|Developer|
|button|Apply To All|
|checkBox|On Mouse Click|
|button|Preview|
|group|Editing|
|group|Clipboard|
|group|Tables|
|group|Links|
|group|Barcode|
|dropDown|Transition Sound:|
|button|Picture...|
|button|From Beginning|
|menu|Switch Windows|
|button|Create New Theme Colors...|
|button|Create New Theme Fonts...|
|button|More Gradients...|
|button|Shadow Options...|
|toggleButton|Align Selected Objects|
|toggleButton|Align to Slide|
|button|Align Left|
|button|Align Right|
|button|Align Top|
|button|Align Bottom|
|button|Align Center|
|button|Align Middle|
|button|Distribute Horizontally|
|button|Distribute Vertically|
|menu|Custom Slide Show|
|dropDown|Resolution:|
|checkBox|Use Rehearsed Timings|
|dropDown|Show Presentation On:|
|group|Monitors|
|gallery|Fonts|
|gallery|Effects|
|toggleButton|Properties|
|tab|Print Preview|
|group|Print|
|group|Preview|
|tab|Options|
|tab|Options|
|group|Play|
|group|Movie Options|
|group|Sound Options|
|checkBox|Hide During Show|
|checkBox|Loop Until Stopped|
|dropDown|Play Sound:|
|gallery|Slide Show Volume|
|checkBox|Play Full Screen|
|checkBox|Rewind Movie After Playing|
|splitButton|Borders|
|toggleButton|Create Document Workspace|
|button|Document Management Server|
|toggleButton|Document Management Information|
|button|Customize Quick Access Toolbar...|
|menu|Prepare|
|toggleButton|Mark as Final|
|button|Add a Digital Signature|
|checkBox|Hide Background Graphics|
|gallery|Change Case|
|splitButton|Delete|
|group|Merge|
|menu|Justify|
|splitButton|Text Box|
|toggleButton|Horizontal Text Box|
|button|Properties|
|gallery|Handout Orientation|
|menu|Slides Per Page|
|checkBox|Slide Image|
|checkBox|Body|
|checkBox|Date|
|checkBox|Page Number|
|checkBox|Header|
|checkBox|Footer|
|tab|Handout Master|
|tab|Notes Master|
|group|Placeholders|
|group|Edit Theme|
|group|Close|
|group|Edit Master|
|group|Master Layout|
|tab|Grayscale|
|tab|Black And White|
|group|Change Selected Object|
|group|Select|
|gallery|Brightness|
|gallery|Contrast|
|gallery|Shading|
|button|Add Shape After|
|button|Add Shape Before|
|button|Add Shape Above|
|button|Add Shape Below|
|button|Add Assistant|
|button|Reset Slide Theme Colors|
|button|Switch Row/Column|
|button|Edit Data...|
|button|Refresh Data|
|button|Change Chart Type...|
|group|Data|
|group|Type|
|group|Table Size|
|gallery|Cell Margins|
|button|Content (Vertical)|
|button|3\-D Rotation Options...|
|button|3\-D Options...|
|gallery|Background Styles|
|gallery|Text Direction|
|group|Table Style Options|
|checkBox|Header Row|
|checkBox|First Column|
|checkBox|Total Row|
|checkBox|Last Column|
|checkBox|Banded Rows|
|checkBox|Banded Columns|
|toggleButton|Selection Pane...|
|button|Left Hanging|
|button|Right Hanging|
|button|Both|
|button|Standard|
|toggleButton|Right to Left|
|button|Custom Margins...|
|checkBox|Message Bar|
|gallery|Other Theme Fills|
|menu|Layout|
|tab|Home|
|gallery|Table|
|toggleButton|Justify|
|toggleButton|Justify Low|
|toggleButton|Distribute|
|button|Excel Spreadsheet|
|tab|Options|
|checkBox|Automatically After:|
|gallery|Slide Orientation|
|group|Menu Commands|
|group|Toolbar Commands|
|group|Ink|
|tab|Pens|
|group|Pens|
|group|Close|
|toggleButton|Ballpoint Pen|
|toggleButton|Felt Tip Pen|
|toggleButton|Highlighter|
|button|Save Current Theme...|
|gallery|Align Text|
|gallery|Character Spacing|
|button|Reset to Match Style|
|button|3\-D Rotation...|
|button|Size and Position...|
|button|Convert to Freeform|
|tab|Design|
|gallery|Convert to SmartArt|
|button|More SmartArt Graphics...|
|gallery|Reflection|
|gallery|Recolor|
|button|Promote|
|button|Demote|
|gallery|Cell Bevel|
|gallery|Table Background|
|button|More Title Options...|
|button|More Legend Options...|
|button|More Data Label Options...|
|button|More Primary Horizontal Axis Title Options...|
|button|More Primary Vertical Axis Title Options...|
|button|More Secondary Horizontal Axis Title Options...|
|button|More Secondary Vertical Axis Title Options...|
|button|More Depth Axis Title Options...|
|button|More Primary Horizontal Gridlines Options...|
|button|More Primary Vertical Gridlines Options...|
|button|More Secondary Horizontal Gridlines Options...|
|button|More Secondary Vertical Gridlines Options...|
|button|More Depth Gridlines Options...|
|button|More Primary Horizontal Axis Options...|
|button|More Primary Vertical Axis Options...|
|button|More Secondary Horizontal Axis Options...|
|button|More Secondary Vertical Axis Options...|
|button|More Depth Axis Options...|
|button|More Data Table Options...|
|button|More Trendline Options...|
|button|More Error Bars Options...|
|button|More Up/Down Bars Options...|
|button|More Plot Area Options...|
|button|More Walls Options...|
|button|More Floor Options...|
|gallery|Secondary Horizontal Axis Title|
|gallery|Secondary Vertical Axis Title|
|gallery|Secondary Horizontal Gridlines|
|gallery|Secondary Vertical Gridlines|
|gallery|Secondary Horizontal Axis|
|gallery|Secondary Vertical Axis|
|group|Custom Toolbars|
|dropDown|Play Movie:|
|splitButton|Bring to Front|
|splitButton|Send to Back|
|menu|Group|
|toggleButton|Color|
|button|PowerPoint 97\-2003 Presentation|
|splitButton|Save As Other Format|
|splitButton|Preview and Print|
|menu|Restrict Permission|
|button|Document Panel|
|group|Modify|
|gallery|Bevel|
|gallery|Bevel|
|button|Clear Table|
|group|Table|
|group|Cell Size|
|menu|Effects|
|gallery|More Glow Colors|
|gallery|More Variations|
|button|More Colors...|
|button|More Colors...|
|button|Add Bullet|
|checkBox|Lock Aspect Ratio|
|button|Picture|
|splitButton|Insert Placeholder|
|button|More Border Colors...|
|button|More Fill Colors...|
|button|Change Picture...|
|group|WordArt Styles|
|gallery|Text Fill|
|gallery|Text Outline|
|button|More Outline Colors...|
|menu|Text Effects|
|gallery|Quick Styles|
|button|Clear WordArt|
|button|Picture...|
|gallery|Gradient|
|button|More Gradients...|
|gallery|Texture|
|gallery|Dashes|
|button|More Lines...|
|gallery|Weight|
|gallery|Shadow|
|button|Shadow Options...|
|button|3\-D Options...|
|gallery|3\-D Rotation|
|button|3\-D Rotation Options...|
|gallery|Glow|
|gallery|More Glow Colors|
|button|More Colors...|
|gallery|Reflection|
|menu|Shape Effects|
|toggleButton|Loop Until Next Sound|
|group|Current Selection|
|group|Labels|
|gallery|Bevel|
|button|Picture Corrections Options...|
|splitButton|Add Shape Options|
|gallery|Notes Page Orientation|
|group|Format|
|gallery|Color|
|button|More Options...|
|button|More Options...|
|button|More Columns...|
|button|Reset Slide Background|
|dropDown|Play Track:|
|group|Shapes|
|group|Text|
|gallery|Picture Border|
|group|Close|
|group|Page Setup|
|group|Page Setup|
|group|Placeholders|
|splitButton|Replace...|
|menu|Select|
|menu|Delete|
|group|Set Up|
|menu|Options|
|button|Delete All Markup in the Presentation|
|splitButton|Paste|
|group|Picture Styles|
|gallery|Quick Styles|
|gallery|Shadow|
|gallery|Glow|
|gallery|Soft Edges|
|gallery|Reflection|
|gallery|3\-D Rotation|
|button|Close Ink Tools|
|group|Show/Hide|
|group|Window|
|checkBox|View Gridlines|
|group|Presentation Views|
|group|Color/Grayscale|
|toggleButton|Encrypt Document|
|button|Format Text Effects...|
|button|More Rotation Options...|
|button|More Textures...|
|button|More Fill Colors...|
|button|Fit to Window|
|group|Page Setup|
|menu|View Direction|
|button|E\-mail as PDF Attachment|
|button|E\-mail as XPS Attachment|
|menu|Picture Effects|
|gallery|Change Shape|
|splitButton|Photo Album...|
|group|Background|
|group|Analysis|
|menu|Publish|
|button|Run Compatibility Checker|
|button|Picture...|
|button|Convert|
|button|Save As|
|button|PowerPoint Presentation|
|button|PowerPoint Show|
|button|Font...|
|button|Paragraph...|
|button|Page Setup...|
|gallery|Quick Styles|
|gallery|Shapes|
|gallery|Quick Styles|
|group|WordArt Styles|
|menu|Arrange|
|button|More Textures...|
|group|Macros|
|button|Find add\-ins for other file formats|
|group|Protect|
|menu|Protect Presentation|
|button|Size and Position...|
|button|Discard Check Out|
|menu|Document|



## ***imageMso Table XE "Custom UI control id table:imageMso table"  XE "Tables:imageMso table"*** 
|**imageMso**|
|:---|
|Spelling|
|FileSave|
|FilePrint|
|ZoomOnePage|
|ZoomPageWidth|
|Zoom100|
|TableInsert|
|ColumnsDialog|
|Numbering|
|Bullets|
|PageOrientationPortraitLandscape|
|OutdentClassic|
|IndentClassic|
|DrawingInsert|
|ChartInsert|
|FileNew|
|Copy|
|Cut|
|Paste|
|FileOpen|
|EnvelopesAndLabelsDialog|
|ZoomPrintPreviewExcel|
|PenComment|
|Folder|
|Repeat|
|UpArrow2|
|RightArrow2|
|DownArrow2|
|LeftArrow2|
|Clear|
|Breakpoint|
|Piggy|
|Superscript|
|Subscript|
|HappyFace|
|UnderlineDouble|
|UnderlineWords|
|FontSizeIncreaseWord|
|FontSizeDecreaseWord|
|_0|
|_1|
|_2|
|_3|
|_4|
|_5|
|_6|
|_7|
|_8|
|_9|
|A|
|B|
|C|
|D|
|E|
|F|
|G|
|H|
|I|
|J|
|K|
|L|
|M|
|N|
|O|
|P|
|Q|
|R|
|S|
|T|
|U|
|V|
|W|
|X|
|Y|
|Z|
|FileClose|
|TableAutoFormat|
|FormatPainter|
|FilePrintPreview|
|PickUpStyle|
|PasteApplyStyle|
|Bold|
|Italic|
|Underline|
|DarkShading|
|ParagraphMarks|
|AlignLeft|
|AlignRight|
|AlignCenter|
|AlignJustify|
|ContextHelp|
|HeaderFooterPageNumberInsert|
|Undo|
|Redo|
|ControlLine|
|ControlRectangle|
|OutlinePromote|
|OutlineDemote|
|OutlineMoveUp|
|OutlineMoveDown|
|OutlineDemoteToBodyText|
|OutlineExpand|
|OutlineCollapse|
|TextBoxInsert|
|FileFind|
|FindDialog|
|TableExcelSpreadsheetInsert|
|AutoFormat|
|BorderTop|
|BorderBottom|
|BorderLeft|
|BorderRight|
|BorderInside|
|BorderOutside|
|BorderNone|
|MailMergeGoToFirstRecord|
|MailMergeGoToPreviousRecord|
|MailMergeGoToNextRecord|
|MailMergeGotToLastRecord|
|MailMergeMergeToDocument|
|MailMergeMergeToPrinter|
|MailMergeAutoCheckForErrors|
|DataFormSource|
|MailMergeResultsPreview|
|ObjectsGroup|
|ObjectsUngroup|
|ObjectBringToFront|
|ObjectSendToBack|
|AboveText|
|BehindText|
|ObjectBringForward|
|ObjectSendBackward|
|Magnifier|
|PrintPreviewShrinkOnePage|
|MultiplePages|
|ViewFullScreenView|
|ViewRulerPowerPoint|
|VoiceInsert|
|ObjectsSelect|
|TableFind|
|MacroRecord|
|MacroRecorderPause|
|MacroPlay|
|ObjectFlipHorizontal|
|ObjectFlipVertical|
|ObjectRotateRight90|
|ObjectRotateLeft90|
|ShapeFreeform|
|GroupDrawing|
|ObjectEditPoints|
|CalloutOptions|
|SortUp|
|SortDown|
|TableDesign|
|DataFormAddRecord|
|DataFormDeleteRecord|
|FieldsUpdate|
|DatabaseInsert|
|GridSettings|
|WordPicture|
|FormControlEditBox|
|FormControlCheckBox|
|FormControlComboBox|
|PropertySheet|
|FieldShading|
|ViewDraftView|
|Lock|
|AutoSum|
|MasterDocumentShow|
|MasterDocumentCreateSubdocument|
|MasterDocumentUnlinkSubdocument|
|MasterDocumentInsertSubdocument|
|MasterDocumentSplitSubdocuments|
|MasterDocumentMergeSubdocuments|
|MasterDocumentLockSubdocument|
|HeaderOrFooterShow|
|HeaderFooterPreviousSection|
|HeaderFooterNextSection|
|AlignDialog|
|MailMergeDocument|
|MergeOptions|
|MailMergeHelper|
|PageSetupDialog|
|BodyTextHide|
|HeaderFooterLinkToPrevious|
|OutlineShowFirstLineOnly|
|OutlineShowTextFormatting|
|FontDialog|
|StylesDialogClassic|
|RoutingSlip|
|FootnoteInsert|
|MicrosoftExcel|
|MicrosoftAccess|
|Schedule|
|MicrosoftVisualFoxPro|
|MicrosoftPowerPoint|
|MicrosoftPublisher|
|MicrosoftProject|
|SadFace|
|Pushpin|
|Camera|
|FormControlButton|
|Calculator|
|ViewPrintLayoutView|
|FieldCodes|
|DropCapOptionsDialog|
|Strikethrough|
|TextSmallCaps|
|CellsDelete|
|TableRowsDelete|
|TableColumnsDelete|
|CellsInsertDialog|
|TableRowsInsertWord|
|QueryInsertColumns|
|WindowsArrangeAll|
|MarginsAdjust|
|ViewGridlinesWord|
|SubdocumentOpen|
|WindowSplit|
|WindowNew|
|LegalBlackline|
|ReviewAcceptOrRejectChangeDialog|
|TextAllCaps|
|PictureDisassemble|
|SymbolInsert|
|ChangeCaseDialogClassic|
|FontSizeDecrease1Point|
|FontSizeIncrease1Point|
|Repaginate|
|ReplaceDialog|
|StartOfLine|
|EndOfLine|
|PagePrevious|
|PageNext|
|TextBoxInsertVertical|
|StartOfDocument|
|EndOfDocument|
|Grammar|
|FileCloseOrCloseAll|
|TextToOrFromTable|
|TableRowsOrColumnsOrCellsInsert|
|TableRowsOrColumnsOrCellsDelete|
|RedoOrRepeat|
|ObjectsRegroup|
|_3DStyle|
|TipWizardHelp|
|AutoFormatChange|
|AddressBook|
|Reply|
|ReplyAll|
|Forward|
|MailMove|
|MailDelete|
|MessagePrevious|
|MessageNext|
|CheckNames|
|MailSelectNames|
|PrintAreaSetPrintArea|
|PasteFormatting|
|FillRight|
|FillDown|
|EqualSign|
|PlusSign|
|MinusSign|
|MultiplicationSign|
|DivisionSign|
|ExponentiationSign|
|ParenthesisLeft|
|ParenthesisRight|
|ColonSign|
|CommaSign|
|PercentSign|
|DollarSign|
|FunctionWizard|
|AsianLayoutCharacterScaling|
|ConstrainNumeric|
|LightShading|
|AccountingFormat|
|PercentStyle|
|CommaStyle|
|DecimalsIncrease|
|DecimalsDecrease|
|MergeCenter|
|FontSizeIncrease|
|FontSizeDecrease|
|TextOrientationVertical|
|TextOrientationRotateUp|
|TextOrientationRotateDown|
|AlignDistributeHorizontallyClassic|
|ShapeScribble|
|ChartAreaChart|
|Chart3DBarChart|
|Chart3DColumnChart|
|Chart3DPieChart|
|ChartRadarChart|
|OutlineSymbolsShowHide|
|TableSelectVisibleCells|
|SelectCurrentRegion|
|FreezePanes|
|ZoomIn|
|ZoomOut|
|FormControlRadioButton|
|FormControlScrollBar|
|FormControlListBox|
|TraceDependentRemoveArrows|
|TraceDependents|
|TracePrecedentsRemoveArrows|
|TraceRemoveAllArrows|
|FileUpdate|
|ReadOnly|
|AutoFilterClassic|
|Refresh|
|PivotTableFieldSettings|
|PivotTableShowPages|
|OutlineShowDetail|
|TraceError|
|OutlineHideDetail|
|AlignDistributeVerticallyClassic|
|FormControlGroupBox|
|FormControlSpinner|
|TabOrder|
|RunDialog|
|FormControlCombinationListEdit|
|FormControlCombinationDropDownEdit|
|FormControlLabel|
|Delete|
|Fish|
|Coffee|
|Heart|
|Diamond|
|Spade|
|Club|
|ViewSheetGridlines|
|TracePrecedents|
|Info|
|CodeEdit|
|InsertDialog|
|ApplyFilter|
|DatasheetView|
|SortAndFilterAdvanced|
|ControlSubFormReport|
|FieldList|
|ViewsFormView|
|Grouping|
|AdpPrimaryKey|
|ControlBoundObjectFrame|
|ControlUnboundObjectFrame|
|PageBreakInsertOrRemove|
|PrintSetupDialog|
|CreateFormInDesignView|
|CreateQueryFromWizard|
|CreateReportInDesignView|
|MacroConditions|
|MacroNames|
|ControlToggleButton|
|DatabaseRelationships|
|TableIndexes|
|ViewsAdpDiagramSqlView|
|QueryTableNamesShowHide|
|QueryShowTable|
|QuerySelectQueryType|
|QueryCrosstab|
|QueryMakeTable|
|QueryUpdate|
|QueryAppend|
|QueryDelete|
|QueryParameters|
|RecordsSaveRecord|
|GoToNewRecord|
|RowHeight|
|ColumnWidth|
|RecordsFreezeColumns|
|GridlinesGallery|
|OleObjectctInsert|
|ControlToolboxOutlook|
|SnapToGrid|
|SizeToFit|
|PageHeaderOrFooterShowHide|
|FormHeaderOrFooterShowHide|
|First10RecordsPreview|
|ControlSpecialEffectRaised|
|ControlSpecialEffectSunken|
|AutoDial|
|FindNext|
|PasteDuplicate|
|DatabasePermissions|
|ControlAlignToGrid|
|ControlSpecialEffectFlat|
|CreateTableInDesignView|
|MacroDefault|
|ModuleInsert|
|FilterToggleFilter|
|FilterClearAllFilters|
|Head|
|ReminderSound|
|CreateModule|
|RelationshipsDirectRelationships|
|RelationshipDesignAllRelationships|
|ControlWizards|
|MergeToWord|
|FilterAdvancedByForm|
|CreateMacro|
|AutoFormatWizard|
|PrintPreviewZoomTwoPages|
|FilterBySelection|
|RecordsDeleteRecord|
|QueryBuilder|
|DatabaseDocumenter|
|DatabaseAnalyzePerformance|
|DatabaseAnalyzeTable|
|ObjectsAlignLeft|
|ObjectsAlignRight|
|ObjectsAlignTop|
|ObjectsAlignBottom|
|ObjectsAlignCenterHorizontal|
|ObjectsAlignMiddleVertical|
|SlideNew|
|ClipArtInsert|
|CreateHandoutsInWord|
|Shadow|
|ObjectRotateFree|
|ShapesMoreShapes|
|CopyToPersonalContacts|
|ParagraphSpacingIncrease|
|ParagraphSpacingDecrease|
|SlideMasterMasterLayout|
|OrganizationChartInsert|
|CollapseAll|
|OutlineExpandAll|
|CombineCharacters|
|DoubleStrikethrough|
|QueryInsertColumn|
|EncryptMessage|
|DigitallySignMessage|
|CreateMailRule|
|ViewNormalViewExcel|
|ViewPageBreakPreviewView|
|SlideHide|
|AnimationCustom|
|PictureCrop|
|SlideShowRehearseTimings|
|ViewSlideView|
|ViewOutlineView|
|ViewSlideSorterView|
|ViewNotesPageView|
|ViewSlideShowView|
|ViewSlideMasterView|
|FileCloseAll|
|FileSaveAs|
|SaveAll|
|AdvancedFileProperties|
|DocumentTemplate|
|FileExit|
|PasteSpecialDialog|
|SelectAll|
|GoTo|
|BookmarkInsert|
|FileLinksToFiles|
|ViewOnlineLayoutViewClassic|
|HeaderFooterInsert|
|FootnotesEndnotesShow|
|BreakInsertDialog|
|DateAndTimeInsert|
|NumberInsert|
|FieldInsert|
|CaptionInsert|
|CrossReferenceInsert|
|TextFromFileInsert|
|ParagraphDialog|
|BordersShadingDialog|
|TextDirectionOptionsDialog|
|BulletsAndNumberingBulletsDialog|
|AutoFormatDialog|
|SetLanguage|
|WordCount|
|AutoCorrect|
|EnvelopesAndLabels|
|LabelsDialog|
|MergeCells|
|SplitCells|
|TableRowSelect|
|TableColumnSelect|
|TableSelect|
|TableRepeatHeaderRows|
|ConvertTextToTable|
|TableFormulaDialog|
|TableSplitTable|
|ShowClipboard|
|TechnicalSupport|
|ImeDictionaryUpdate|
|OutlookTaskCreate|
|WindowMinimize|
|WindowRestore|
|WindowClose|
|WindowSaveWorkspace|
|SheetDelete|
|ViewFormulaBar|
|SheetInsert|
|FormatCellsDialog|
|DataFormExcel|
|OutlineSubtotals|
|Consolidate|
|WindowHide|
|WindowUnhide|
|FillUp|
|FillLeft|
|ClearFormats|
|NameCreateFromSelection|
|SheetProtect|
|ReviewProtectWorkbook|
|MacroRelativeReferences|
|Filter|
|SortClear|
|AdvancedFilterDialog|
|OutlineSettings|
|PrintPreviewClose|
|HeaderFooterClose|
|ZoomDialog|
|SortDialogClassic|
|ConvertTableToText|
|PictureInsertFromFilePowerPoint|
|ExchangeFolder|
|VisualBasicReferences|
|ViewCustomViews|
|SheetBackground|
|ChartEditDataSource|
|ChartPlacement|
|CalculateNow|
|ObjectEditDialog|
|ObjectFormatDialog|
|QueryRunQuery|
|ControlImage|
|RulerShowHide|
|GridShowHide|
|ContentsAndIndex|
|Help|
|PivotTableEnableSelection|
|PivotTableListFormulas|
|PivotTableSelectData|
|PivotTableSelectLabelAndData|
|PivotTableSelectLabel|
|CalculateSheet|
|FontColorMoreColorsDialog|
|FillEffects|
|TextOrientationAngleCounterclockwise|
|TextOrientationAngleClockwise|
|HyperlinkOpenExcel|
|OpenStartPage|
|WebGoBack|
|WebGoForward|
|AddToFavorites|
|BrowsePrevious|
|BrowseNext|
|BrowseSelector|
|SmartArtInsert|
|ShapeRerouteConnectors|
|ObjectNudgeUp|
|ObjectNudgeDown|
|ObjectNudgeLeft|
|ObjectNudgeRight|
|ShapeCurve|
|ShapeStraightConnector|
|ShapeElbowConnector|
|ObjectFillMoreColorsDialog|
|ObjectBorderOutlineColorMoreColorsDialog|
|LineStylesDialog|
|ArrowsMore|
|TextEffectAlignment|
|TextEffectTracking|
|WordArtVerticalText|
|WordArtEvenTextHeightClassic|
|ContrastMore|
|ContrastLess|
|BrightnessMore|
|BrightnessLess|
|ShadowNudgeUpClassic|
|ShadowNudgeDownClassic|
|ShadowNudgeLeftClassic|
|ShadowNudgeRightClassic|
|ObjectShadowColorMoreColorsDialog|
|HighImportance|
|LowImportance|
|AttachMenu|
|InviteAttendees|
|AcceptInvitation|
|DeclineInvitation|
|TentativeAcceptInvitation|
|NewContact|
|NewTask|
|NewAppointment|
|TextAlignLeft|
|TextAlignCenter|
|ShapeRectangle|
|ShapeRoundedRectangle|
|ShapeIsoscelesTriangle|
|ShapeOval|
|ShapeSmileyFace|
|ShapeDonut|
|ShapeLeftBrace|
|ShapeRightBrace|
|ShapeArc|
|ShapeLightningBolt|
|ShapeHeart|
|ShapeRightArrow|
|ShapeLeftArrow|
|ShapeUpArrow|
|ShapeDownArrow|
|ShapeRoundedRectangularCallout|
|ShapeStar|
|ShapeSeal8|
|ShapeSeal16|
|ShapeSeal24|
|TextAlignRight|
|TextAlignLetterJustify|
|TextAlignWordJustify|
|TextAlignStretchJustify|
|PictureReset|
|PictureRecolorAutomatic|
|PictureRecolorGrayscale|
|PictureRecolorBlackAndWhite|
|PictureRecolorWashout|
|TextWrappingSquare|
|TextWrappingTight|
|TextWrappingNoneClassic|
|TextWrappingEditWrapPoints|
|_3DEffectsOnOffClassic|
|_3DTiltDownClassic|
|_3DTiltUpClassic|
|_3DTiltLeftClassic|
|_3DTiltRightClassic|
|_3DExtrusionDirectionClassic|
|_3DLightingClassic|
|_3DSurfaceMaterialClassic|
|_3DExtrusionDepthNoneClassic|
|_3DExtrusionDepth36Classic|
|_3DExtrusionDepth72Classic|
|_3DExtrusionDepth144Classic|
|_3DExtrusionDepth288Classic|
|_3DExtrusionDepthInfinityClassic|
|_3DExtrusionPerspectiveClassic|
|_3DExtrusionParallelClassic|
|_3DLightingFlatClassic|
|_3DLightingNormalClassic|
|_3DLightingDimClassic|
|_3DSurfaceMatteClassic|
|_3DSurfacePlasticClassic|
|_3DSurfaceMetalClassic|
|_3DSurfaceWireFrameClassic|
|ObjectEditText|
|SnapToShapes|
|TextWrappingMenuClassic|
|WindowsArrangeIcons|
|PictureFormatDialog|
|ViewVisualBasicCode|
|RemoveFromCalendar|
|MasterViewClose|
|CreateShortcutMenuFromMacro|
|DrawingNewClassic|
|HyperlinkInsert|
|HyperlinkEdit|
|ReviewNewComment|
|ReviewPreviousComment|
|ReviewNextComment|
|ReviewDeleteComment|
|ReviewShowOrHideComment|
|ReviewShowAllComments|
|PivotTableOptions|
|DesignMode|
|WordArtInsertDialogClassic|
|FormFieldProperties|
|PhoneticGuideEdit|
|FullScreenViewClassic|
|PhoneticGuideSettings|
|PhoneticGuideFieldShow|
|CircularReferences|
|MasterDocumentExpandOrCollapseSubdocuments|
|Chart3DConeChart|
|InternationalCurrency|
|ObjectsAlignCenterInFormHorixontally|
|ObjectsAlignCenterInFormVertically|
|SizeToControlWidth|
|SizeToControlHeight|
|SizeToControlHeightAndWidth|
|HorizontalSpacingDecrease|
|HorizontalSpacingIncrease|
|ObjectsAlignDistributeHorizontallyRemove|
|VerticalSpacingDecrease|
|VerticalSpacingIncrease|
|ObjectsAlignDistributeVerticallyRemove|
|ObjectsArrangeBottom|
|ObjectsArrangeRight|
|CancelMeeting|
|Private|
|AcceptTask|
|SaveAndNew|
|CopyFolder|
|EmptyTrash|
|RecordInJournal|
|MarkAsUnread|
|CopyToFolder|
|MoveToFolder|
|ShapeFillColorPickerClassic|
|ControlLineColorPicker|
|VisualBasic|
|DoubleBottomBorder|
|BorderThickBottom|
|BorderTopAndBottom|
|BorderTopAndDoubleBottom|
|BorderTopAndThickBottom|
|BordersAll|
|BorderThickOutside|
|SlideBackgroundFormatDialog|
|AutoSummarize|
|ViewDocumentMap|
|ReviewAcceptChange|
|ReviewRejectChange|
|TableDrawBorderPenStyle|
|Font|
|FontSize|
|ZoomClassic|
|CreateMap|
|MergeCellsAcross|
|FieldChooser|
|MessageHeaderToggle|
|MeetingRequest|
|NewNote|
|RecurrenceEdit|
|SendStatusReport|
|ImagerScan|
|QueryReturnGallery|
|SelectRecord|
|SelectAllRecords|
|TableTestValidationRules|
|RelationshipsClearLayout|
|SaveAsQuery|
|LoadFromQuery|
|DatasheetColumnRename|
|FileServerLinkTables|
|DatasheetColumnLookup|
|RecordsRefreshRecords|
|RelationshipsEditRelationships|
|RelationshipsHideTable|
|ReplicationRecoverDesignMaster|
|ReplicationResolveConflicts|
|ReplicationCreateReplica|
|ReplicationSynchronizeNow|
|SetDatabasePassword|
|DatabaseUserLevelSecurityWizard|
|DatabaseUserAndGroupAccounts|
|ControlSpecialEffectEtched|
|ControlSpecialEffectShadowed|
|ControlSpecialEffectChiseled|
|WindowsCascade|
|PositionFitToWindow|
|BorderInsideHorizontal|
|BorderInsideVertical|
|BorderDiagonalDown|
|BorderDiagonalUp|
|MagicEightBall|
|TextDirectionLeftToRight|
|TextDirectionRightToLeft|
|ActiveXCheckBox|
|FindDialogExcel|
|ActiveXTextBox|
|ActiveXButton|
|ActiveXRadioButton|
|ActiveXListBox|
|ActiveXComboBox|
|ActiveXToggleButton|
|ActiveXSpinButton|
|ActiveXScrollBar|
|ActiveXLabel|
|ShowBcc|
|ShowFrom|
|DefinePrintStyles|
|TagMarkComplete|
|NewContactFromSameCompany|
|ChooseForm|
|RecoverInviteToMeeting|
|FormPublish|
|SkipOccurrence|
|RightToLeftDocument|
|EditQuery|
|DataRangeProperties|
|RefreshAll|
|RefreshCancel|
|RefreshStatus|
|ClearAll|
|NewPostInThisFolder|
|ReplyToAttendeesWithMessage|
|SaveAndClose|
|AssignTask|
|Recurrence|
|NewMessageToContact|
|NewTaskForContact|
|NewMeetingWithContact|
|NewMessageToAttendees|
|SendUpdate|
|ReplyToAllAttendeesWithMessage|
|PostReplyToFolder|
|ViewAppointmentInCalendar|
|NewJournalEntry|
|NewMailMessage|
|CancelAcceptTask|
|CancelTaskAssignment|
|CancelDeclineTask|
|NewTaskRequest2|
|RecurrenceEditSeries|
|DataValidation|
|DataValidationCircleInvalid|
|ReviewShareWorkbook|
|ReviewTrackChanges|
|ReviewHighlightChanges|
|DatabaseQueryNew|
|DataValidationClearValidationCircles|
|ReviewEditComment|
|TableDrawTable|
|TableEraser|
|TableCellAlignTop|
|TableCellAlignCenterVertically|
|TableCellAlignBottom|
|TableColumnsDistribute|
|TableRowsDistribute|
|FileCompactAndRepairDatabase|
|DatabaseMakeMdeFile|
|DatabaseEncodeDecode|
|SizeToTallest|
|SizeToShortest|
|SizeToWidest|
|SizeToNarrowest|
|QueryUnionQuery|
|QueryDataDefinition|
|QuerySqlPassThroughQuery|
|ClearGrid|
|ActiveXFrame|
|ActiveXImage|
|ShapeConnectorStyleStraight|
|ShapeConnectorStyleElbow|
|ShapeConnectorStyleCurved|
|WordArtEditTextClassic|
|FilterByResource|
|TableInsertCellsDialog|
|DeleteCells2|
|TableDeleteRows|
|TableDeleteColumns|
|Organizer|
|ShadowOnOrOffClassic|
|MacroRecorderStop|
|FileSendAsAttachment|
|AutoSummaryViewByHighlight|
|MasterDocument|
|ChangeCase|
|ListNumFieldInsert|
|ParagraphSpaceBeforeNone|
|ParagraphSpaceBefore|
|ParagraphSpaceAddOrRemoveBefore|
|PagePreviousWord|
|PageNextWord|
|MailMergeRecepientsUseExistingList|
|FootnoteNextWord|
|EndnoteInsertWord|
|IndexMarkEntry|
|CitationMark|
|IndexInsert|
|TableOfContentsDialog|
|TableOfFiguresInsert|
|TableOfAuthoritiesInsert|
|TextBoxLinkCreate|
|TextBoxLinkBreak|
|TextBoxNextLinked|
|TextBoxPreviousLinked|
|CompareAndCombine|
|PrintOptionsMenuWord|
|PageNumberFormat|
|CancelInvitation|
|ContactWebPage|
|AttachItem|
|SendAgain|
|EditComposePage|
|EditReadPage|
|DesignThisForm|
|FileNewDefault|
|FilePrintQuick|
|WindowsTileVertically|
|WindowsTileHorizontally|
|SpellingAndGrammar|
|CopyToPersonalCalendar|
|CopyToPersonalTaskList|
|Post|
|NewOfficeDocument|
|CreateClassModule|
|ControlTabControl|
|ControlPage|
|ReviewPreviousChangeClassic|
|ReviewNextChangeClassic|
|DialMenu|
|SendDefault|
|MessageProperties|
|PictureInsertFromFile|
|TableDrawBorderPenWeight|
|FormatObject2|
|TableShowGridlines|
|TableBorderPenColorPicker|
|ShowAutoShapesAndDrawingBars|
|ShapeStraightConnectorArrow|
|ShapeElbowConnectorArrow|
|SourceControlAddObjects|
|SourceControlGetLatestVersion|
|SourceControlCheckOut|
|SourceControlCheckIn|
|SourceControlUndoCheckOut|
|SourceControlShareObjects|
|SourceControlShowDifferences|
|SourceControlShowHistory|
|SourceControlRun|
|SourceControlProperties|
|SourceControlCreateDatabaseFromProject|
|SourceControlAddDatabase|
|SourceControlOptions|
|SourceControlRefreshStatus|
|DatabaseMoveToSharePoint|
|NewPostInThisFolder3|
|SlideDelete|
|ViewHandoutMasterView|
|ViewNotesMasterView|
|SlidesReuseSlides|
|SlidesFromOutline|
|MovieFromFileInsert|
|SoundInsertFromFile|
|FontsReplaceFonts|
|SpeakerNotes|
|BlackAndWhiteAutomatic|
|BlackAndWhiteBlack|
|BlackAndWhiteBlackWithGrayscaleFill|
|BlackAndWhiteBlackWithWhiteFill|
|BlackAndWhiteDontShow|
|BlackAndWhiteGrayWithWhiteFill|
|BlackAndWhiteGrayscale|
|BlackAndWhiteInverseGrayscale|
|BlackAndWhiteWhite|
|BlackAndWhiteLightGrayscale|
|RecordNarration|
|SlideShowSetUpDialog|
|SummarizeSlide|
|TextWrappingTopAndBottom|
|TextWrappingThrough|
|MoveToFolderMenu|
|MacroRecordOrStop|
|PasteAsHyperlink|
|ParagraphDistributed|
|HyphenationOptions|
|TableRowsOrColumnsDistribute|


# **Change Tracking XE "Change tracking"  XE "Tracking changes"** 

This section identifies changes that were made to this document since the last release. Changes are classified as Major, Minor, or None. 

The revision class **Major** means that the technical content in the document was significantly revised. Major changes affect protocol interoperability or implementation. Examples of major changes are:

- A document revision that incorporates changes to interoperability requirements.

- A document revision that captures changes to protocol functionality.

The revision class **Minor** means that the meaning of the technical content was clarified. Minor changes do not affect protocol interoperability or implementation. Examples of minor changes are updates to clarify ambiguity at the sentence, paragraph, or table level.

The revision class **None** means that no new technical changes were introduced. Minor editorial and formatting changes may have been made, but the relevant technical content is identical to the last released version.

The changes made to this document are listed in the following table. For more information, please contact [dochelp@microsoft.com](mailto:dochelp@microsoft.com).
|**Section**|**Description**|**Revision class**|
|:---|:---|:---|
|[4]() Appendix B: Product Behavior|Updated list of supported products.|major|


# **Index**

***C***


[Change tracking]() PAGEREF section_7e45371b0f1d4ff6b01f2fcbef31233f523

Custom UI

   [parts]() PAGEREF section_edc80b0591694ff795ee03af067f35b19

Custom UI control id table

   [imageMso table]() PAGEREF section_fe2124a15aaa4adfb2855d58da9d5e2a419


***E***


[Elements]() PAGEREF section_d842006e31874f66a17d0819a3cc94b511

   [box (box grouping container)]() PAGEREF section_fb660d68051e4a86ab97e0d93b32817e11

   [button (button inside of a split button)]() PAGEREF section_2257e779b94944cb8ec0719a46421f3e34

   [button (button)]() PAGEREF section_846e8fb607d3460b816bbcfae841c95b15

   [button (unsized button)]() PAGEREF section_2e7b9955ff774a2f9d93401f0541e8fd25

   [buttonGroup (button grouping container)]() PAGEREF section_d9f6097943e740e6bd211f9693600c2143

   [checkBox (check box)]() PAGEREF section_d189aedcd7634295bc2b07746447dfde46

   [comboBox (combo box)]() PAGEREF section_3caf6b1834cb4352bd3177a26980c00e56

   [command (repurposed command)]() PAGEREF section_21316865fbce4a3fa9ffa8277cce5f2d67

   [commands (list of repurposed commands)]() PAGEREF section_f914543a2b8e48d4bf5e98b1326e7fc269

   [contextualTabs (list of contextual tab sets)]() PAGEREF section_75ae6d6f6a8549a2a5fb84b970d54ffb69

   [control (control clone)]() PAGEREF section_f2bf1b5d049246a488f7dc1a9528f75578

   [control (Quick Access Toolbar control clone)]() PAGEREF section_14909d674b9f4796badae79edaedcdf287

   [control (unsized control clone)]() PAGEREF section_ada8edc4b469410e8bd05d667ffe7dbf70

   [customUI (custom UI document root)]() PAGEREF section_8a27e8523f8b424aac6732c58181e9d396

   [dialogBoxLauncher (dialog box launcher)]() PAGEREF section_76d9f8786b2749ff8c4cee008f345cac97

   [documentControls (list of document-specific Quick Access Toolbar controls)]() PAGEREF section_de33fcbe3b5b4d30b875d2ec922cf32f98

   [dropDown (drop-down control)]() PAGEREF section_700e4451870640c58d7b896e4ae21b6999

   [dynamicMenu (dynamic menu)]() PAGEREF section_26d7db807ea442d09a063f63365043c7120

   [dynamicMenu (unsized dynamic menu)]() PAGEREF section_fd0825c70f294038861754af0dec8c7d111

   [editBox (edit box)]() PAGEREF section_7b552756a970466db7c2ee5bbe171e34131

   [gallery (gallery)]() PAGEREF section_017f9f94700f4846ba19c695ad32929f140

   [gallery (unsized gallery)]() PAGEREF section_7bfba338481f453e97670e0855c8f029156

   [group (group)]() PAGEREF section_190f51e63a3c4cf8affbcec9b906aae4170

   [item (selection item)]() PAGEREF section_6417edcc85b847f781fd56918e8df537178

   [labelControl (text label)]() PAGEREF section_965555a293db48a6a6bf5dd08a13f6bb181

   [menu (dynamic menu root XML element)]() PAGEREF section_e662c00135584511a56507a3e32021e3219

   [menu (menu with title)]() PAGEREF section_f785dc2b045b4b86b5424a10d264dace198

   [menu (menu)]() PAGEREF section_0243b261903e43d98e8b43f66ea0bcaf208

   [menu (unsized menu)]() PAGEREF section_1590adf87f2a4ec8944f9c4329e7ff98189

   [menuSeparator (menu separator)]() PAGEREF section_00c26e34b4a84c97a4f6d547a555a686221

   [officeMenu (Office menu)]() PAGEREF section_d9422554dbaf42e09e4b6416a80b0844224

   [qat (Quick Access Toolbar)]() PAGEREF section_93e2f741a06c40968dbf5a97fefca545225

   [ribbon (ribbon)]() PAGEREF section_574eeee87a03406ab95ff9e51e53dd9d226

   [separator (separator)]() PAGEREF section_21312cb8be0f412c8184acd533a1410b227

   [sharedControls (list of shared Quick Access Toolbar controls)]() PAGEREF section_0ca32ee5aae74ff18baa8a8c9be2ebb3230

   [splitButton (split button with title)]() PAGEREF section_1c6721206402408b96dde98650c12da5239

   [splitButton (split button)]() PAGEREF section_aa41c698c7e84486b15fb73bedbf2be8248

   [splitButton (unsized split button)]() PAGEREF section_6477dffcc8f24fc9815b637dabf3911d231

   [tab (tab)]() PAGEREF section_141f881ca5a4473f944955d3d36579ed257

   [tabs (list of tabs)]() PAGEREF section_6cbd1ae9780f421886aec536f6c0e97a261

   [tabSet (contextual tab set)]() PAGEREF section_90a00968474745128601b61440747033262

   [toggleButton (toggle button inside of a split button)]() PAGEREF section_539b9c44822d45cb8abe66b65a8bc14c283

   [toggleButton (toggle button)]() PAGEREF section_ec42bfd0149c495b895c3bc708b8a149273

   [toggleButton (unsized toggle button)]() PAGEREF section_69b127857fce431591c145aa114726ea263


***G***


[Glossary]() PAGEREF section_315de154485a48fca96e8c1a2b3209647


***I***


idMso tables

   [Excel 2007]() PAGEREF section_bb5bb594ec8c45f68424f98e8308b25a358

   [PowerPoint 2007]() PAGEREF section_f2a8e3c014cb4ad388cda8b5b1b9a8a0393

   [Word 2007]() PAGEREF section_a9f90d736e694bb78e384f268cd42038304

[Informative references]() PAGEREF section_dbe3a851c6b94ae0ba7984f1e88432d18

[Introduction]() PAGEREF section_5b5f9bab46874f838f2cb743c813e4c37


***N***


[Normative references]() PAGEREF section_ea98067859b3466892052fedb66150138


***P***


Parts

   [additional part types]() PAGEREF section_728fd283b4524a14ba8c33100cf6f0889

   [quick access toolbar customizations part]() PAGEREF section_087c607c5565418c8d31772b91d93ff39

   [ribbon extensibility part]() PAGEREF section_52faf7b6fecc48d996dbee80a631a5ac10

[Product behavior]() PAGEREF section_30685057c9f24d9c82acf3274539540f522


***R***


References

   [informative]() PAGEREF section_dbe3a851c6b94ae0ba7984f1e88432d18

   [normative]() PAGEREF section_ea98067859b3466892052fedb66150138


***S***


[Simple types]() PAGEREF section_869c8c9a45f84119b068f61e76d04322292

   [ST_BoxStyle (box style)]() PAGEREF section_3a299df5af064f4f813db0043d772546292

   [ST_Delegate (callback function name)]() PAGEREF section_188cc098eef7453e895cd96e8e99576c292

   [ST_GalleryItemWidthHeight (gallery item width or height)]() PAGEREF section_76f0a96c409d49a5927028e9b6b7f0a4295

   [ST_GalleryRowColumnCount (gallery row or column count)]() PAGEREF section_b09148682e5949dd96cfdf995849a1bf295

   [ST_ID (control identifier)]() PAGEREF section_18fbbd72e04f48148f9a45b2c4cc8393296

   [ST_ItemSize (menu item size)]() PAGEREF section_c65c8b6052e5404dad5a8c09627c60eb297

   [ST_Keytip (key tip)]() PAGEREF section_78170415e2fa4fc0899a76096fdc6aa6297

   [ST_LongString (long string)]() PAGEREF section_94ee0d879533413ebf87bbee57270f7e298

   [ST_QID (qualified control identifier)]() PAGEREF section_7c80b304b2f8432a83ee7f8ec792af0c298

   [ST_Size (control size)]() PAGEREF section_acf53d2ea68046de946752a2f4a51631300

   [ST_String (short string)]() PAGEREF section_d104fcb261774eb9a4000a5f8ddcd539301

   [ST_StringLength (string length)]() PAGEREF section_4a327c6229ec496e935fa1aa77d26d5e302


**\[MS\-CUSTOMUI]:** 

**Custom UI XML Markup Specification**


Intellectual Property Rights Notice for Open Specifications Documentation


- **Technical Documentation.** Microsoft publishes Open Specifications documentation (“this documentation”) for protocols, file formats, data portability, computer languages, and standards support. Additionally, overview documents cover inter\-protocol relationships and interactions. 

- **Copyrights**. This documentation is covered by Microsoft copyrights. Regardless of any other terms that are contained in the terms of use for the Microsoft website that hosts this documentation, you can make copies of it in order to develop implementations of the technologies that are described in this documentation and can distribute portions of it in your implementations that use these technologies or in your documentation as necessary to properly document the implementation. You can also distribute in your implementation, with or without modification, any schemas, IDLs, or code samples that are included in the documentation. This permission also applies to any documents that are referenced in the Open Specifications documentation. 

- **No Trade Secrets**. Microsoft does not claim any trade secret rights in this documentation. 

- **Patents**. Microsoft has patents that might cover your implementations of the technologies described in the Open Specifications documentation. Neither this notice nor Microsoft's delivery of this documentation grants any licenses under those patents or any other Microsoft patents. However, a given Open Specifications document might be covered by the Microsoft [Open Specifications Promise](http://go.microsoft.com/fwlink/?LinkId=214445) or the [Microsoft Community Promise](http://go.microsoft.com/fwlink/?LinkId=214448). If you would prefer a written license, or if the technologies described in this documentation are not covered by the Open Specifications Promise or Community Promise, as applicable, patent licenses are available by contacting [iplg@microsoft.com](mailto:iplg@microsoft.com). 

- **License Programs**. To see all of the protocols in scope under a specific license program and the associated patents, visit the [Patent Map](https://msdn.microsoft.com/en-us/openspecifications/dn750984). 

- **Trademarks**. The names of companies and products contained in this documentation might be covered by trademarks or similar intellectual property rights. This notice does not grant any licenses under those rights. For a list of Microsoft trademarks, visit [www.microsoft.com/trademarks](http://www.microsoft.com/trademarks). 

- **Fictitious Names**. The example companies, organizations, products, domain names, email addresses, logos, people, places, and events that are depicted in this documentation are fictitious. No association with any real company, organization, product, domain name, email address, logo, person, place, or event is intended or should be inferred.

**Reservation of Rights**. All other rights are reserved, and this notice does not grant any rights other than as specifically described above, whether by implication, estoppel, or otherwise. 

**Tools**. The Open Specifications documentation does not require the use of Microsoft programming tools or programming environments in order for you to develop an implementation. If you have access to Microsoft programming tools and environments, you are free to take advantage of them. Certain Open Specifications documents are intended for use in conjunction with publicly available standards specifications and network programming art and, as such, assume that the reader either is familiar with the aforementioned material or has immediate access to it.

**Support.** For questions and support, please contact [dochelp@microsoft.com](mailto:dochelp@microsoft.com). 

**Preliminary Documentation.** This particular Open Specifications document provides documentation for past and current releases and/or for the pre\-release version of this technology. This document provides final documentation for past and current releases and preliminary documentation, as applicable and specifically noted in this document, for the pre\-release version. Microsoft will release final documentation in connection with the commercial release of the updated or new version of this technology. Because this documentation might change between the pre\-release version and the final version of this technology, there are risks in relying on this preliminary documentation. To the extent that you incur additional development obligations or any other costs as a result of relying on this preliminary documentation, you do so at your own risk.

![A group of clovers  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img12.jpeg)![A blue text on a white background  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img13.png)![A person in a red jacket  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img14.png)![A camera on a table  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img15.jpeg)![A grey and white background  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img16.jpeg)


**Revision Summary**
|**Date**|**Revision History**|**Revision Class**|**Comments**|
|:---|:---|:---|:---|
|1/15/2009|1.0|Major|Initial Availability|
|7/13/2009|1.01|Major|Revised and edited the technical content|
|8/28/2009|1.02|Editorial|Revised and edited the technical content|
|11/6/2009|1.03|Editorial|Revised and edited the technical content|
|2/19/2010|2.0|Editorial|Revised and edited the technical content|
|3/31/2010|2.01|Editorial|Revised and edited the technical content|
|4/30/2010|2.02|Editorial|Revised and edited the technical content|
|6/7/2010|2.03|Editorial|Revised and edited the technical content|
|6/29/2010|2.04|Editorial|Changed language and formatting in the technical content.|
|7/23/2010|2.04|None|No changes to the meaning, language, or formatting of the technical content.|
|9/27/2010|2.04|None|No changes to the meaning, language, or formatting of the technical content.|
|11/15/2010|2.04|None|No changes to the meaning, language, or formatting of the technical content.|
|12/17/2010|2.04|None|No changes to the meaning, language, or formatting of the technical content.|
|3/18/2011|2.04|None|No changes to the meaning, language, or formatting of the technical content.|
|6/10/2011|2.04|None|No changes to the meaning, language, or formatting of the technical content.|
|1/20/2012|2.5|Minor|Clarified the meaning of the technical content.|
|4/11/2012|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|7/16/2012|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|10/8/2012|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|2/11/2013|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|7/30/2013|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|11/18/2013|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|2/10/2014|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|4/30/2014|2.5|None|No changes to the meaning, language, or formatting of the technical content.|
|7/31/2014|2.6|Minor|Clarified the meaning of the technical content.|
|10/30/2014|3.0|Major|Significantly changed the technical content.|
|3/16/2015|4.0|Major|Significantly changed the technical content.|
|9/4/2015|4.0|None|No changes to the meaning, language, or formatting of the technical content.|
|7/15/2016|4.0|None|No changes to the meaning, language, or formatting of the technical content.|
|9/14/2016|4.0|None|No changes to the meaning, language, or formatting of the technical content.|
|10/17/2016|4.0|None|No changes to the meaning, language, or formatting of the technical content.|
|7/10/2017|5.0|Major|Significantly changed the technical content.|
|9/19/2017|6.0|Major|Significantly changed the technical content.|
|4/27/2018|7.0|Major|Significantly changed the technical content.|



# **Introduction XE "Introduction"** 


In creating an interoperable implementation, it is helpful to understand specific implementation choices made by other products implementing the same standard. For example, portions of the standard may provide only general guidance, leaving specific implementation choices up to the application implementer; in some circumstances it may be helpful for other implementers to understand those choices. 


The information contained in this document provides information about how to implement UI customization in the context of ECMA\-376 Office Open XML File Formats, as described in [[ECMA-376]](https://go.microsoft.com/fwlink/?LinkId=200054).

## ***Glossary XE "Glossary"*** 

This document uses the following terms:

**add\-in**: Supplemental functionality that is provided by an external application or macro to extend the capabilities of an application.


**KeyTip**: A small, pop\-up window that appears over commands on the ribbon when users press the ALT key. By pressing the key that is displayed in a KeyTip, users can execute the command that is associated with the KeyTip.


**macro**: A set of instructions that are recorded or written, and then typically saved to a file. When a macro is run, all of the instructions are performed automatically.

**XML fragment**: Lines of text that adhere to XML tag rules, as described in [[XML]](https://go.microsoft.com/fwlink/?LinkId=90598), but do not have a Document Type Definition (DTD) or schema, processing instructions, or any other header information.


**XML namespace**: A collection of names that is used to identify elements, types, and attributes in XML documents identified in a URI reference [[RFC3986]](https://go.microsoft.com/fwlink/?LinkId=90453). A combination of XML namespace and local name allows XML documents to use elements, types, and attributes that have the same names but come from different sources. For more information, see [[XMLNS-2ED]](https://go.microsoft.com/fwlink/?LinkId=90602).

**XML namespace prefix**: An abbreviated form of an [XML namespace](), as described in \[XML].

**XML schema**: A description of a type of XML document that is typically expressed in terms of constraints on the structure and content of documents of that type, in addition to the basic syntax constraints that are imposed by XML itself. An XML schema provides a view of a document type at a relatively high level of abstraction.

**XML schema definition (XSD)**: The World Wide Web Consortium (W3C) standard language that is used in defining XML schemas. Schemas are useful for enforcing structure and constraining the types of data that can be used validly within other XML documents. XML schema definition refers to the fully specified and currently recommended standard for use in authoring [XML schemas]().

**MAY, SHOULD, MUST, SHOULD NOT, MUST NOT:** These terms (in all caps) are used as defined in [[RFC2119]](https://go.microsoft.com/fwlink/?LinkId=90317). All statements of optional behavior use either MAY, SHOULD, or SHOULD NOT.

## ***References***

Links to a document in the Microsoft Open Specifications library point to the correct section in the most recently published version of the referenced document. However, because individual documents in the library are not updated at the same time, the section numbers in the documents may not match. You can confirm the correct section numbering by checking the [Errata](https://go.microsoft.com/fwlink/?linkid=850906).  

### **Normative References XE "References:normative"  XE "Normative references"** 

We conduct frequent surveys of the normative references to assure their continued availability. If you have any issue with finding a normative reference, please contact [dochelp@microsoft.com](mailto:dochelp@microsoft.com). We will assist you in finding the relevant information. 

\[ECMA\-376] ECMA International, "Office Open XML File Formats", 1st Edition, ECMA\-376, December 2006, [http://www.ecma-international.org/publications/standards/Ecma-376.htm](https://go.microsoft.com/fwlink/?LinkId=200054)

\[MS\-CUSTOMUI2] Microsoft Corporation, "[Custom UI XML Markup Version 2 Specification]()".

\[RFC2119] Bradner, S., "Key words for use in RFCs to Indicate Requirement Levels", BCP 14, RFC 2119, March 1997, [http://www.rfc-editor.org/rfc/rfc2119.txt](https://go.microsoft.com/fwlink/?LinkId=90317)

\[XMLNS] Bray, T., Hollander, D., Layman, A., et al., Eds., "Namespaces in XML 1.0 (Third Edition)", W3C Recommendation, December 2009, [http://www.w3.org/TR/2009/REC-xml-names-20091208/](https://go.microsoft.com/fwlink/?LinkId=191840)

\[XMLSCHEMA1] Thompson, H., Beech, D., Maloney, M., and Mendelsohn, N., Eds., "XML Schema Part 1: Structures", W3C Recommendation, May 2001, [http://www.w3.org/TR/2001/REC-xmlschema-1-20010502/](https://go.microsoft.com/fwlink/?LinkId=90608)

\[XMLSCHEMA2] Biron, P.V., Ed. and Malhotra, A., Ed., "XML Schema Part 2: Datatypes", W3C Recommendation, May 2001, [http://www.w3.org/TR/2001/REC-xmlschema-2-20010502/](https://go.microsoft.com/fwlink/?LinkId=90610)

### **Informative References XE "References:informative"  XE "Informative references"** 

None.

# **Custom UI XE "Custom UI: parts"**

The subordinate clauses specify the semantics for the Custom UI XML markup contained within the ECMA\-376 Office Open XML File Formats, as specified in [[ECMA-376]](https://go.microsoft.com/fwlink/?LinkId=200054). These semantics describe customization of the UI interface. Examples in the following clauses highlight customizations in the context of the Microsoft Office Fluent interface (UI) but the concepts extend naturally to any user interface.

Customization of the UI is accomplished via the addition of parts containing Custom UI XML markup to the containing document package.

## ***Parts XE "Parts:additional part types"*** 

The parts described in the subordinate sections detail the additional part types utilized by CustomUI in an ECMA\-376 Office Open XML File Formats [[ECMA-376]](https://go.microsoft.com/fwlink/?LinkId=200054) file.

### **Quick Access Toolbar Customizations Part XE "Parts:quick access toolbar customizations part"** 
|**Content Type:**|**application/xml**|
|:---|:---|
|Root Namespace:|http://schemas.microsoft.com/office/2006/01/customui|
|Source Relationship:|http://schemas.microsoft.com/office/2006/relationships/ui/userCustomization|


The syntax of the structures contained in this part uses [XML schema definition (XSD)](), as specified in [[XMLSCHEMA1]](https://go.microsoft.com/fwlink/?LinkId=90608) and [[XMLSCHEMA2]](https://go.microsoft.com/fwlink/?LinkId=90610).

This specification defines and references various [XML namespaces]() by using the mechanisms specified in [[XMLNS]](https://go.microsoft.com/fwlink/?LinkId=191840).

An instance of this part type contains information about the quick access toolbar customizations specific to the containing package. 

For example, a user can customize the quick access toolbar for his WordProcessingML document to contain the UI controls that they commonly use.

A package is permitted to contain at most one Quick Access Toolbar Customizations part, and that part is the target of a relationship in the package\-relationship item for the document.

For example, the following package part\-relationship item contains a relationship to a Quick Access Toolbar Customizations part, which is stored in the ZIP item /userCustomization/customUI.xml:

\<Relationships xmlns\="…"\>

\<Relationship Id\="rId2" 

Type\="http://…/2006/relationships/ui/userCustomization"

Target\="/userCustomization/customUI.xml" /\>

\</Relationships\>

The root element for a part of this content type is **customUI**.

For example, the following Quick Access Toolbar Customizations content markup specifies that the control with identifier "SpellingAndGrammar" is to be added to the quick access toolbar for the package:

\<mso:customUI xmlns:mso\="http://schemas.microsoft.com/office/2006/01/customui"\>

\<mso:ribbon\>

\<mso:qat\>

\<mso:documentControls\>

\<mso:control idQ\="mso:SpellingAndGrammar" visible\="true" /\>

\</mso:documentControls\>

\</mso:qat\>

\</mso:ribbon\>

\</mso:customUI\>

A Quick Access Toolbar Customizations part is located within the package containing the source relationship. Expressed syntactically, the **TargetMode** attribute of the **Relationship** element is "Internal".

A Quick Access Toolbar Customizations part does not have implicit or explicit relationships to any other part defined by ECMA\-376 Office Open XML File Formats, as specified in [[ECMA-376]](https://go.microsoft.com/fwlink/?LinkId=200054).

### **Ribbon Extensibility Part XE "Parts:ribbon extensibility part"** 
|**Content Type:**|**application/xml**|
|:---|:---|
|Root Namespace:|http://schemas.microsoft.com/office/2006/01/customui|
|Source Relationship:|http://schemas.microsoft.com/office/2006/relationships/ui/extensibility|


The syntax of the structures contained in this part uses [XML schema definition (XSD)](), as specified in [[XMLSCHEMA1]](https://go.microsoft.com/fwlink/?LinkId=90608) and [[XMLSCHEMA2]](https://go.microsoft.com/fwlink/?LinkId=90610).

This specification defines and references various [XML namespaces]() by using the mechanisms specified in [[XMLNS]](https://go.microsoft.com/fwlink/?LinkId=191840).

An instance of this part type contains information about the ribbon customizations specific to the containing package.

For example, a SpreadsheetML document that represents a timecard could contain custom UI controls to guide the user in filling out the timecard.

A package is permitted to contain at most one Ribbon Extensibility part, and that part is the target of a relationship in the package\-relationship item for the document.

For example, the following package part\-relationship item contains a relationship to a Ribbon Extensibility part, which is stored in the ZIP item /customUI/customUI.xml:

\<Relationships xmlns\="…"\>

\<Relationship Id\="rId5"  

Type\="http://…/2006/relationships/ui/extensibility"

Target\="/customUI/customUI.xml" /\>

\</Relationships\>

The root element for a part of this content type is **customUI**.

For example, the following Ribbon Extensibility content markup specifies that the ribbon tab with identifier "TabHome" is to be hidden for the containing package:

\<customUI xmlns\="http://schemas.microsoft.com/office/2006/01/customui"\>

\<ribbon\>

\<tabs\>

\<tab idMso\="TabHome" visible\="false" /\>

\</tabs\>

\</ribbon\>

\</customUI\>

A Ribbon Extensibility part is located within the package containing the source relationship. Expressed syntactically, the **TargetMode** attribute of the **Relationship** element is "Internal".

A Ribbon Extensibility part is permitted to have explicit relationships to the following parts defined by ECMA\-376 Office Open XML File Formats, as specified in [[ECMA-376]](https://go.microsoft.com/fwlink/?LinkId=200054):

- Image Part, as specified in \[ECMA\-376] Part 1 section15.2.13.

- ![A camera on a table  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img17.jpeg)![A grey and white background  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img18.jpeg)![A red silhouette of a family  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img19.png)![A person in a suit and tie  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img20.png)![A person in a suit and tie  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img21.png)![Picture](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img22.png)![A tree in a field  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img23.jpeg)![A tree in a field  Description automatically generated](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img24.jpeg)

## ***Elements XE "Elements"*** 

A Custom UI document contains customizations of an application's UI. Customizations are mainly of two types:

Modifications of the application's built\-in UI, such as hiding or disabling built\-in UI controls or repurposing command actions.

Creation of custom UI controls, such as a custom ribbon tab, menu item, or quick access toolbar button.

For example, consider the following Custom UI document:

\<customUI xmlns\="http://schemas.microsoft.com/office/2006/01/customui"\>

  \<commands\>

    \<command idMso\="Bold" enabled\="false" /\>

  \</commands\>

  \<ribbon\>

    \<tabs\>

      \<tab idMso\="TabHome" visible\="false" /\>

      \<tab id\="CustomTab" label\="Custom Tab"\>

        \<group id\="CustomGroup" label\="Custom Group"\>

          \<button id\="CustomButton" label\="Custom Button" 

            size\="large" imageMso\="HappyFace" onAction\="OnButtonClick" /\>

        \</group\>

      \</tab\>

    \</tabs \>

  \</ribbon\>

\</customUI\>

This example disables the command with an identifier of "Bold", hides the ribbon tab with an identifier of "TabHome", and creates a new custom ribbon tab with a custom button in it.

The full XML Schema Definition of the XML Schema fragments listed in this section is defined in Appendix A of [[MS-CUSTOMUI2]]().

### **box (Box Grouping Container) XE "Elements:box (box grouping container)"** 

This element specifies a grouping container control that can be used to align controls vertically or horizontally. **Box** elements can be nested to create complex UI layouts.

For example, consider a group of controls that are laid out horizontally, as follows:

![Controls grouped horizontally](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img25.png)

**Figure  SEQ Figure \\\* ARABIC 1: Controls grouped horizontally**

This layout is specified using the following [XML fragment]():

\<box id\="box" boxStyle\="horizontal"\>

  \<button id\="button1" label\="Button 1" imageMso\="HappyFace" /\>

  \<button id\="button2" label\="Button 2" imageMso\="HappyFace" /\>

\</box\>

This is contrasted to the default vertical layout that is used if the **box** element is not specified.

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|**Section**|
|:---|:---|
|**box**|2.2.1|
|**group**|[2.2.23]()|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**box** (Box Grouping Container)|2.2.1|
|**button** (Button)|[2.2.2]()|
|**buttonGroup** (Button Grouping Container)|[2.2.5]()|
|**checkBox** (Check Box)|[2.2.6]()|
|**comboBox** (Combo Box)|[2.2.7]()|
|**control** (Control Clone)|[2.2.12]()|
|**dropDown** (Drop\-down Control)|[2.2.17]()|
|**dynamicMenu** (Dynamic Menu)|[2.2.19]()|
|**editBox** (Edit Box)|[2.2.20]()|
|**gallery** (Gallery)|[2.2.21]()|
|**labelControl** (Text Label)|[2.2.25]()|
|**menu** (Menu)|[2.2.28]()|
|**splitButton** (Split Button)|[2.2.38]()|
|**toggleButton** (Toggle Button)|[2.2.43]()|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**boxStyle** (box style)|Specifies the layout direction for the child controls inside of the **box** element. If this attribute is omitted, the child controls SHOULD be laid out horizontally. For example, consider a group of controls to be laid out vertically. This is specified using the following XML: \<box id\="box" boxStyle\="vertical"\>   … \</box\> The possible values for this attribute are defined by the **ST_BoxStyle** simple type, as specified in section [2.3.1]().|
|**getVisible** ( **getVisible** callback)|Specifies the name of a callback function that is called to determine the visibility state of this control. The **getVisible** and **visible** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible. For example, consider the following XML fragment: \<button id\="button" getVisible\="IsButtonVisible" /\> In this example, the **IsButtonVisible** callback function is called when the application needs to determine the visibility of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section [2.3.2]().|
|**id** (control identifier)|Specifies the identifier for a custom control. All custom controls MUST have unique identifiers. The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call. The **id** and **idQ** attributes are mutually exclusive. At least one of these attributes is to be specified. For example, consider the following XML fragment: \<button id\="MyButton" label\="Button" /\> This specifies a custom button control with an **id** of "MyButton". The possible values for this attribute are defined by the **ST_UniqueID** simple type, as specified in section [2.3.13]().|
|**idQ** (qualified control identifier)|Specifies a qualified identifier for a control. The **idQ** attribute can be used to reference controls or **containers** created by other Custom UI documents. The **id** and **idQ** attributes are mutually exclusive. At least one of these attributes is to be specified. For example, consider the following XML fragment: \<customUI    xmlns\="http://schemas.microsoft.com/office/2006/01/customui"   xmlns:ex\="http://www.example.com"\>   \<ribbon\>     \<tabs\>      \<tab idQ\="ex:OtherTab" label\="Shared Tab"\>         \<group id\="MyGroup" label\="My Group"\>           …         \</group\>       \</tab\>     \</tabs\>   \</ribbon\> \</customUI\> In this case, **ex** is an [XML namespace prefix]() for the namespace http://www.example.com. This XML fragment refers to a **tab** in that namespace with an identifier of "OtherTab". If that tab cannot be found, it is created. A new group belonging to this file is added to the tab. The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section [2.3.9]().|
|**insertAfterMso** (identifier of built\-in control to insert after)|Specifies the identifier of a built\-in control that this control is to be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the built\-in tab with an **id** of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section [2.3.5]().|
|**insertAfterQ** (qualified identifier of control to insert after)|Specifies the qualified identifier of a control that this control is to be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an **id** of "MyTab" is to be inserted after the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**insertBeforeMso** (identifier of built\-in control to insert before)|Specifies the identifier of a built\-in control that this control is to be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an **id** of "MyTab" is to be inserted before the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple, as specified in section 2.3.5.|
|**insertBeforeQ** (qualified identifier of control to insert before)|Specifies the qualified identifier of a control that this control is to be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an **id** of "MyTab" is to be inserted before the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**visible** (control visibility)|Specifies the visibility state of the control. The **getVisible** and **visible** attributes are mutually exclusive. If these attributes are omitted, the control SHOULD default to being visible. For example, consider the following XML fragment: \<tab idMso\="TabHome" visible\="false" /\> In this example, the built\-in tab with an identifier of "TabHome" is to be hidden. The possible values for this attribute are defined by the [XML schema]() **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Box"\>

   \<xsd:group ref\="EG_Controls" minOccurs\="0" maxOccurs\="1000"/\>

   \<xsd:attributeGroup ref\="AG_IDCustom"/\>

   \<xsd:attributeGroup ref\="AG_Visible"/\>

   \<xsd:attributeGroup ref\="AG_PositionAttributes"/\>

   \<xsd:attribute name\="boxStyle" type\="ST_BoxStyle" use\="optional"/\>

\</xsd:complexType\>

### **button (Button) XE "Elements:button (button)"** 

This element specifies a standard push\-button control that performs an action when clicked.

For example, consider a button control, as follows:

![A button control](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img26.png)

**Figure  SEQ Figure \\\* ARABIC 2: A button control**

This is specified using the following XML fragment:

\<button id\="button" label\="Button" imageMso\="HappyFace" /\>

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|**Section**|
|:---|:---|
|**box**|[2.2.1]()|
|**group**|[2.2.23]()|


The following table summarizes the attributes of this element.

The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Button"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_ButtonRegular"\>

   \<xsd:attributeGroup ref\="AG_SizeAttributes"/\>

   \</xsd:extension\>

   \</xsd:complexContent\>

This element specifies a gallery control, which displays a drop\-down grid of items that the user can select from. A gallery can optionally have buttons following its selection items.

For example, consider a gallery control that shows a selection of pictures, as follows:

![A gallery control](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img27.png)

**Figure  SEQ Figure \\\* ARABIC 12: A gallery control**

This is specified using the following XML fragment:

\<gallery id\="gallery" label\="Gallery" itemWidth\="88" itemHeight\="68" 

         size\="large" imageMso\="HappyFace" \>

  \<item id\="item1" image\="Desert" /\>

  \<item id\="item2" image\="Forest" /\>

  \<item id\="item3" image\="Toucan" /\>

  \<item id\="item4" image\="Tree" /\>

\</gallery\>

The following table summarizes the elements that are parents of this element.

The following table summarizes the child elements of this element.

The following table summarizes the attributes of this element.

The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Gallery"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_GalleryRegular"\>

   \<xsd:attributeGroup ref\="AG_SizeAttributes"/\>

   \</xsd:extension\>

   \</xsd:complexContent\>

This element specifies the quick access toolbar. If the containing Custom UI file is a Ribbon Extensibility part the **qat** element cannot be used unless the **startFromScratch** attribute on the ribbon element is set to "true". In this case only the **sharedControls** child element SHOULD be used.  If the containing Custom UI file is a Quick Access Toolbar Customizations part, the **documentControls** child element SHOULD be used.

For example, consider the following controls on the document\-specific quick access toolbar:

![Controls on the quick access toolbar](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img28.png)

**Figure  SEQ Figure \\\* ARABIC 20: Controls on the quick access toolbar**

This is specified using the following XML fragment:

\<qat\>

  \<documentControls\>

    \<control idMso\="CalculateNow" /\>

    \<control idMso\="HyperlinkInsert" /\>

  \</documentControls\>

\</qat\>

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**ribbon** (section [2.2.33]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**documentControls** (List of Document\-Specific Quick Access Toolbar Controls)|[2.2.16]()|
|**sharedControls** (List of Shared Quick Access Toolbar Controls)|[2.2.35]()|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Qat"\>

   \<xsd:sequence\>

   \<xsd:element name\="sharedControls" type\="CT_QatItems" minOccurs\="0"/\>

   \<xsd:element name\="documentControls" type\="CT_QatItems" minOccurs\="0"/\>

   \</xsd:sequence\>

\</xsd:complexType\>

### **ribbon (Ribbon) XE "Elements:ribbon (ribbon)"** 

This element is used to reference the Ribbon of the application and its contents.

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**customUI** (section [2.2.14]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**contextualTabs** (List of Contextual Tab Sets)|[2.2.10]()|
|**officeMenu** (Office Menu)|[2.2.31]()|
|**qat** (Quick Access Toolbar)|[2.2.32]()|
|**tabs** (List of Tabs)|[2.2.40]()|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**startFromScratch** (start from scratch)|Specifies that the application's built\-in ribbon UI is reduced to a minimal set of features, providing a clean slate on which to build custom UI. If this attribute is omitted, its value SHOULD default to "false". For example, consider the following XML fragment:  \<ribbon startFromScratch\="true"\>   … \</ribbon\> In this example, the application's ribbon is put into start from scratch mode. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Ribbon"\>

   \<xsd:all\>

   \<xsd:element name\="officeMenu" type\="CT_OfficeMenu" minOccurs\="0" maxOccurs\="1"/\>

   \<xsd:element name\="qat" type\="CT_Qat" minOccurs\="0" maxOccurs\="1"\>

   \<xsd:unique name\="qatControls"\>

   \<xsd:selector xpath\="\*/\*"/\>

   \<xsd:field xpath\="@id"/\>

   \</xsd:unique\>

   \</xsd:element\>

   \<xsd:element name\="tabs" type\="CT_Tabs" minOccurs\="0" maxOccurs\="1"/\>

   \<xsd:element name\="contextualTabs" type\="CT_ContextualTabs" minOccurs\="0" maxOccurs\="1"/\>

   \</xsd:all\>

   \<xsd:attribute name\="startFromScratch" type\="xsd:boolean" use\="optional"/\>

\</xsd:complexType\>

### **separator (Separator) XE "Elements:separator (separator)"** 

This element specifies a vertical separator line between two sets of controls, either in the Quick Access Toolbar or within **group** elements.

For example, consider a vertical separator control between two buttons, as follows:

![A vertical separator control](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img29.png)

**Figure  SEQ Figure \\\* ARABIC 21: A vertical separator control**

This is specified using the following XML fragment:

\<button id\="button1" label\="Button 1" imageMso\="HappyFace" size\="large" /\>

\<separator id\="separator" /\>

\<button id\="button2" label\="Button 2" imageMso\="HappyFace" size\="large" /\>

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**documentControls** (section [2.2.16]()); **group** (section [2.2.23]()); **sharedControls** (section [2.2.35]())|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**getVisible** ( **getVisible** callback)|Specifies the name of a callback function to be called to determine the visibility state of this control. The **getVisible** and **visible** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible. For example, consider the following XML fragment: \<button id\="button" getVisible\="IsButtonVisible" /\> In this example, the **IsButtonVisible** callback function is called when the application needs to determine the visibility of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section [2.3.2]().|
|**id** (control identifier)|Specifies the identifier for a custom control. All custom controls MUST have unique identifiers. The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call. The **id** and **idQ** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<button id\="MyButton" label\="Button" /\> This specifies a custom button control with an identifier of "MyButton". The possible values for this attribute are defined by the **ST_UniqueID** simple type, as specified in section [2.3.13]().|
|**idQ** (qualified control identifier)|Specifies a qualified identifier for a control. The **idQ** attribute can be used to reference controls or containers created by other Custom UI documents. The **id** and **idQ** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<customUI    xmlns\="http://schemas.microsoft.com/office/2006/01/customui"   xmlns:ex\="http://www.example.com"\>   \<ribbon\>     \<tabs\>      \<tab idQ\="ex:OtherTab" label\="Shared Tab"\>         \<group id\="MyGroup" label\="My Group"\>           …         \</group\>       \</tab\>     \</tabs\>   \</ribbon\> \</customUI\> In this case, **ex** is an XML namespace prefix for the namespace http://www.example.com. This XML fragment refers to a **tab** in that namespace with an identifier of "OtherTab". If that tab cannot be found, it is created. A new group belonging to this file is added to the tab. The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section [2.3.9]().|
|**insertAfterMso** (identifier of built\-in control to insert after)|Specifies the identifier of a built\-in control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section [2.3.5]().|
|**insertAfterQ** (qualified identifier of control to insert after)|Specifies the qualified identifier of a control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**insertBeforeMso** (identifier of built\-in control to insert before)|Specifies the identifier of a built\-in control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertBeforeQ** (qualified identifier of control to insert before)|Specifies the qualified identifier of a control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**visible** (control visibility)|Specifies the visibility state of the control. The **getVisible** and **visible** attributes are mutually exclusive. If these attributes are omitted, the control SHOULD default to being visible. For example, consider the following XML fragment: \<tab idMso\="TabHome" visible\="false" /\> In this example, the built\-in tab with an identifier of "TabHome" is hidden. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_Separator"\>

   \<xsd:attributeGroup ref\="AG_IDCustom"/\>

   \<xsd:attributeGroup ref\="AG_Visible"/\>

   \<xsd:attributeGroup ref\="AG_PositionAttributes"/\>

\</xsd:complexType\>

### **sharedControls (List of Shared Quick Access Toolbar Controls) XE "Elements:sharedControls (list of shared Quick Access Toolbar controls)"** 

This element specifies the section of the quick access toolbar that is shared among all documents. This element SHOULD NOT be specified if the containing Custom UI XML document is a Quick Access Toolbar Customizations part. If the containing Custom UI XML document is a Ribbon Extensibility part, this element can be used if the **startFromScratch** attribute is set to "true" on the ribbon element.

For example, consider a Ribbon Extensibility XML document that adds the two buttons to the shared section of the quick access toolbar:

![Shared controls on the quick access toolbar](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img30.png)

**Figure  SEQ Figure \\\* ARABIC 22: Shared controls on the quick access toolbar**

This is specified using the following XML fragment:

\<qat\>

 \<sharedControls\>

  \<button id\="button1" imageMso\="HappyFace" /\>

  \<button idMso\="Cut" /\>

 \</sharedControls\>

\</qat\>

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**qat** (section [2.2.32]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**button** (Unsized Button)|[2.2.3]()|
|**control** (Quick Access Toolbar Control Clone)|[2.2.13]()|
|**separator** (Separator)|[2.2.34]()|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_QatItems"\>

   \<xsd:sequence\>

   \<xsd:choice minOccurs\="0" maxOccurs\="1000"\>

   \<xsd:element name\="control" type\="CT_ControlCloneQat"/\>

   \<xsd:element name\="button" type\="CT_ButtonRegular"/\>

   \<xsd:element name\="separator" type\="CT_Separator"/\>

   \</xsd:choice\>

   \</xsd:sequence\>

\</xsd:complexType\>

### **splitButton (Unsized Split Button) XE "Elements:splitButton (unsized split button)"** 

This element specifies a split button control that, because of its location, cannot have its size changed. The **size** attribute is not present. It otherwise behaves identically to the regular **splitButton** element, as specified in section [2.2.38]().

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**buttonGroup** (section [2.2.5]()); **menu** (section [2.2.28]()); **menu** (section [2.2.26]()); **menu** (section [2.2.29]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**button** (Button Inside of a Split Button)|[2.2.4]()|
|**menu** (Unsized Menu)|2.2.26|
|**toggleButton** (Toggle Button Inside of a Split Button)|[2.2.44]()|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**enabled** (enabled state)|Specifies the enabled state of the control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. This attribute cannot be used to enable a built\-in control that would otherwise be disabled by the application. For example, consider the following XML fragment: \<button id\="button" label\="Disabled Button" enabled\="false" /\> This specifies a new button that is disabled. A permanently disabled button is not very useful, thus the **enabled** attribute is not commonly used. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**getEnabled** ( **getEnabled** callback)|Specifies the name of a callback function to be called to determine the enabled state of this control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. For example, consider the following XML fragment: \<button id\="button" getEnabled\="IsButtonEnabled" /\> In this example, the **IsButtonEnabled** callback function is called when the application needs to determine the enabled state of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section [2.3.2]().|
|**getImage** ( **getImage** callback)|Specifies the name of a callback function to be called to determine the icon of this control. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getImage\="GetButtonImage" /\> In this example, the **GetButtonImage** callback function is called when the application needs to determine the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getKeytip** ( **getKeytip** callback)|Specifies the name of a callback function to be called to determine the suggested [KeyTip]() of this control. The **getKeytip** and **keytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider the following XML fragment: \<button id\="button" getKeytip\="GetButtonKeytip" /\> In this example, the **GetButtonKeytip** callback function is called when the application needs to determine the KeyTip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getLabel** ( **getLabel** callback)|Specifies the name of a callback function to be called to determine the label of this control. The **getLabel** and **label** attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getLabel\="GetButtonLabel" /\> In this example, the **GetButtonLabel** callback function is called when the application needs to determine the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getScreentip** ( **getScreentip** callback)|Specifies the name of a callback function to be called to determine the screentip of this control. The **getScreentip** and **screentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider the following XML fragment: \<button id\="button" getScreentip\="GetButtonScreentip" /\> In this example, the **GetButtonScreentip** callback function is called when the application needs to determine the screentip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowImage** ( **getShowImage** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the icon of this control.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider the following XML fragment: \<button id\="button" getShowImage\="IsButtonImageVisible" /\> In this example, the **IsButtonImageVisible** callback function is called when the application needs to determine whether to display the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowLabel** ( **getShowLabel** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the label of this control.  The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" getShowLabel\="IsButtonLabelVisible" /\> In this example, the **IsButtonLabelVisible** callback function is called when the application needs to determine whether to display the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getSupertip** ( **getSupertip** callback)|Specifies the name of a callback function to be called to determine the supertip of this control. The **getSupertip** and **supertip** attributes are mutually exclusive. If neither attribute is specified, no supertip for this control SHOULD be shown. For example, consider the following XML fragment: \<button id\="button" getSupertip\="GetButtonSupertip" /\> In this example, the **GetButtonSupertip** callback function is called when the application needs to determine the supertip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getVisible** ( **getVisible** callback)|Specifies the name of a callback function to be called to determine the visibility state of this control. The **getVisible** and **visible** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible. For example, consider the following XML fragment: \<button id\="button" getVisible\="IsButtonVisible" /\> In this example, the **IsButtonVisible** callback function is called when the application needs to determine the visibility of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**id** (control identifier)|Specifies the identifier for a custom control. All custom controls MUST have unique identifiers. The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<button id\="MyButton" label\="Button" /\> This specifies a custom button control with an identifier of "MyButton". The possible values for this attribute are defined by the **ST_UniqueID** simple type, as specified in section [2.3.13]().|
|**idMso** (built\-in control identifier)|Specifies the identifier of a built\-in control.  The contents of this attribute are application\-defined. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<control idMso\="Bold" /\> This creates a clone of the control with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section [2.3.5]().|
|**idQ** (qualified control identifier)|Specifies a qualified identifier for a control. The **idQ** attribute can be used to reference controls or containers created by other Custom UI documents. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<customUI    xmlns\="http://schemas.microsoft.com/office/2006/01/customui"   xmlns:ex\="http://www.example.com"\>   \<ribbon\>     \<tabs\>      \<tab idQ\="ex:OtherTab" label\="Shared Tab"\>         \<group id\="MyGroup" label\="My Group"\>           …         \</group\>       \</tab\>     \</tabs\>   \</ribbon\> \</customUI\> In this case, **ex** is an XML namespace prefix for the namespace http://www.example.com. This XML fragment refers to a **tab** in that namespace with an identifier of "OtherTab". If that tab cannot be found, it is created. A new group belonging to this file is added to the tab. The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section [2.3.9]().|
|**image** (custom image identifier)|Specifies the relationship identifier for an image which SHOULD be used as the icon for this control. This attribute is used to specify an embedded picture that resides locally within the containing file. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" image\="ForestPic" /\> This specifies a custom button whose icon SHOULD be the embedded image file referenced by the relationship identifier of "ForestPic". The possible values for this attribute are defined by the **ST_Uri** simple type, as specified in section [2.3.14]().|
|**imageMso** (built\-in image identifier)|Specifies the identifier of a built\-in image which SHOULD be used as the icon of this control. The contents of this attribute are application\-defined and SHOULD be ignored if not understood. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" imageMso\="Bold" /\> This specifies a custom button that SHOULD use the built\-in image with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterMso** (identifier of built\-in control to insert after)|Specifies the identifier of a built\-in control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterQ** (qualified identifier of control to insert after)|Specifies the qualified identifier of a control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**insertBeforeMso** (identifier of built\-in control to insert before)|Specifies the identifier of a built\-in control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertBeforeQ** (qualified identifier of control to insert before)|Specifies the qualified identifier of a control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**keytip** (keytip)|Specifies a **string** to be used as the suggested KeyTip for this control. The **keytip** and **getKeytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider a button with KeyTip 'K', as follows: ![Button with Key Tip K](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img31.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" keytip\="K" /\> The possible values for this attribute are defined by the **ST_Keytip** simple type, as specified in section [2.3.7]().|
|**label** (label)|Specifies a **string** to be used as the label for this control. The **label** and **getLabel** attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" label\="Custom Button" /\> This specifies a custom **button** with a **label** of "Custom Button". The possible values for this attribute are defined by the **ST_String** simple type, as specified in section [2.3.11]().|
|**screentip** (screentip)|Specifies a **string** to be shown as the screentip for this control. The **screentip** and **getScreentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider a button with a screentip, as follows: ![Button with screen tip String](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img32.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="This is the screentip" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**showImage** (show image)|Specifies whether this control displays an icon.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider a button that does not display an icon, as follows: ![Button with no icon](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img33.png) This is specified using the following XML fragment: \<button id\="button" showImage\="false"    label\="Button with no icon" /\>  The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**showLabel** (show label)|Specifies whether this control SHOULD display its label.   The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" label\="Label" showLabel\="false"    imageMso\="HappyFace" /\> This specifies a **button** that has a **label**, but does not show it. Even though the **label** is hidden, it is provided to accessibility tools. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**supertip** (supertip)|Specifies a **string** to be shown as the supertip of the control. The **supertip** and **getSupertip** attributes are mutually exclusive. If neither attribute is specified no supertip for this control SHOULD be shown. For example, consider a control with a supertip, as follows: ![Button with super stip string](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img34.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="Screentip"   supertip\="This is the supertip string" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**tag** (tag)|Specifies an arbitrary **string** that can be used to hold data or identify the control. The contents of this attribute SHOULD be passed to any callback functions specified on this control. If this attribute is omitted, the control's **tag** value SHOULD default to an empty **string**. For example, consider the following XML fragment: \<button id\="button" label\="Button" tag\="123456"    onAction\="ButtonClicked" /\> This specifies a **button** with a **tag** value of "123456", which is passed to the **ButtonClicked** callback function. The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**visible** (control visibility)|Specifies the visibility state of the control. The **getVisible** and **visible** attributes are mutually exclusive. If these attributes are omitted, the control SHOULD default to being visible. For example, consider the following XML fragment: \<tab idMso\="TabHome" visible\="false" /\> In this example, the built\-in tab with an identifier of "TabHome" is hidden. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_SplitButtonRegular"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_SplitButtonRestricted"\>

   \<xsd:sequence minOccurs\="0"\>

   \<xsd:choice minOccurs\="0"\>

   \<xsd:element name\="button" type\="CT_VisibleButton"/\>

   \<xsd:element name\="toggleButton" type\="CT_VisibleToggleButton"/\>

   \</xsd:choice\>

   \<xsd:element name\="menu" type\="CT_MenuRegular"/\>

   \</xsd:sequence\>

   \</xsd:extension\>

   \</xsd:complexContent\>

\</xsd:complexType\>

### **splitButton (Split Button with Title) XE "Elements:splitButton (split button with title)"** 

This element specifies a split button control that, because of its location, can optionally include a title string via the **title** or **getTitle** attributes. It otherwise behaves identically to the regular **splitButton** element, as specified in section [2.2.38]().

The following table summarizes the elements that are parents of this element.
|**Parent Elements**|
|:---|
|**menu** (section [2.2.27]()); **officeMenu** (section [2.2.31]())|


The following table summarizes the child elements of this element.
|**Child Elements**|**Section**|
|:---|:---|
|**button** (Button Inside of a Split Button)|[2.2.4]()|
|**menu** (Menu with Title)|2.2.27|
|**toggleButton** (Toggle Button Inside of a Split Button)|[2.2.44]()|


The following table summarizes the attributes of this element.
|**Attributes**|**Description**|
|:---|:---|
|**enabled** (enabled state)|Specifies the enabled state of the control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. This attribute cannot be used to enable a built\-in control that would otherwise be disabled by the application. For example, consider the following XML fragment: \<button id\="button" label\="Disabled Button" enabled\="false" /\> This specifies a new button that is disabled. A permanently disabled button is not very useful, thus the **enabled** attribute is not commonly used. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**getEnabled** ( **getEnabled** callback)|Specifies the name of a callback function to be called to determine the enabled state of this control. The **getEnabled** and **enabled** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being enabled. For example, consider the following XML fragment: \<button id\="button" getEnabled\="IsButtonEnabled" /\> In this example, the **IsButtonEnabled** callback function is called when the application needs to determine the enabled state of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section [2.3.2]().|
|**getImage** ( **getImage** callback)|Specifies the name of a callback function to be called to determine the icon of this control. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getImage\="GetButtonImage" /\> In this example, the **GetButtonImage** callback function is called when the application needs to determine the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getKeytip** ( **getKeytip** callback)|Specifies the name of a callback function to be called to determine the suggested [KeyTip]() of this control. The **getKeytip** and **keytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider the following XML fragment: \<button id\="button" getKeytip\="GetButtonKeytip" /\> In this example, the **GetButtonKeytip** callback function is called when the application needs to determine the KeyTip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getLabel** ( **getLabel** callback)|Specifies the name of a callback function to be called to determine the label of this control. The **getLabel** and **label** attributes are mutually exclusive. If neither attribute is specified, no label SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" getLabel\="GetButtonLabel" /\> In this example, the **GetButtonLabel** callback function is called when the application needs to determine the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getScreentip** ( **getScreentip** callback)|Specifies the name of a callback function to be called to determine the screentip of this control. The **getScreentip** and **screentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider the following XML fragment: \<button id\="button" getScreentip\="GetButtonScreentip" /\> In this example, the **GetButtonScreentip** callback function is called when the application needs to determine the screentip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowImage** ( **getShowImage** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the icon of this control.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider the following XML fragment: \<button id\="button" getShowImage\="IsButtonImageVisible" /\> In this example, the **IsButtonImageVisible** callback function is called when the application needs to determine whether to display the icon of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getShowLabel** ( **getShowLabel** callback)|Specifies the name of a callback function to be called to determine whether the application SHOULD display the label of this control.  The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" getShowLabel\="IsButtonLabelVisible" /\> In this example, the **IsButtonLabelVisible** callback function is called when the application needs to determine whether to display the label of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getSupertip** ( **getSupertip** callback)|Specifies the name of a callback function to be called to determine the supertip of this control. The **getSupertip** and **supertip** attributes are mutually exclusive. If neither attribute is specified, no supertip for this control SHOULD be shown. For example, consider the following XML fragment: \<button id\="button" getSupertip\="GetButtonSupertip" /\> In this example, the **GetButtonSupertip** callback function is called when the application needs to determine the supertip of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**getVisible** ( **getVisible** callback)|Specifies the name of a callback function to be called to determine the visibility state of this control. The **getVisible** and **visible** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible. For example, consider the following XML fragment: \<button id\="button" getVisible\="IsButtonVisible" /\> In this example, the **IsButtonVisible** callback function is called when the application needs to determine the visibility of the button. The possible values for this attribute are defined by the **ST_Delegate** simple type, as specified in section 2.3.2.|
|**id** (control identifier)|Specifies the identifier for a custom control. All custom controls MUST have unique identifiers. The identifier of a control SHOULD be passed to callback functions to identify which control corresponds to the function call. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<button id\="MyButton" label\="Button" /\> This specifies a custom button control with an identifier of "MyButton". The possible values for this attribute are defined by the **ST_UniqueID** simple type, as specified in section [2.3.13]().|
|**idMso** (built\-in control identifier)|Specifies the identifier of a built\-in control.  The contents of this attribute are application\-defined. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<control idMso\="Bold" /\> This creates a clone of the control with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section [2.3.5]().|
|**idQ** (qualified control identifier)|Specifies a qualified identifier for a control. The **idQ** attribute can be used to reference controls or containers created by other Custom UI documents. The **id**, **idQ**, and **idMso** attributes are mutually exclusive. At least one of these attributes MUST be specified. For example, consider the following XML fragment: \<customUI    xmlns\="http://schemas.microsoft.com/office/2006/01/customui"   xmlns:ex\="http://www.example.com"\>   \<ribbon\>     \<tabs\>      \<tab idQ\="ex:OtherTab" label\="Shared Tab"\>         \<group id\="MyGroup" label\="My Group"\>           …         \</group\>       \</tab\>     \</tabs\>   \</ribbon\> \</customUI\> In this case, **ex** is an XML namespace prefix for the namespace http://www.example.com. This XML fragment refers to a **tab** in that namespace with an identifier of "OtherTab". If that tab cannot be found, it is created. A new group belonging to this file is added to the tab. The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section [2.3.9]().|
|**image** (custom image identifier)|Specifies the relationship identifier for an image which SHOULD be used as the icon for this control. This attribute is used to specify an embedded picture that resides locally within the containing file. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" image\="ForestPic" /\> This specifies a custom button whose icon SHOULD be the embedded image file referenced by the relationship identifier of "ForestPic". The possible values for this attribute are defined by the **ST_Uri** simple type, as specified in section [2.3.14]().|
|**imageMso** (built\-in image identifier)|Specifies the identifier of a built\-in image which SHOULD be used as the icon of this control. The contents of this attribute are application\-defined and SHOULD be ignored if not understood. The **getImage**, **image**, and **imageMso** attributes are mutually exclusive. If none of these attributes are specified, no icon SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" imageMso\="Bold" /\> This specifies a custom button that SHOULD use the built\-in image with an identifier of "Bold". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterMso** (identifier of built\-in control to insert after)|Specifies the identifier of a built\-in control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertAfterQ** (qualified identifier of control to insert after)|Specifies the qualified identifier of a control that this control SHOULD be inserted after. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertAfterQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted after the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**insertBeforeMso** (identifier of built\-in control to insert before)|Specifies the identifier of a built\-in control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeMso\="TabHome" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the built\-in tab with an identifier of "TabHome". The possible values for this attribute are defined by the **ST_ID** simple type, as specified in section 2.3.5.|
|**insertBeforeQ** (qualified identifier of control to insert before)|Specifies the qualified identifier of a control that this control SHOULD be inserted before. If the value of this attribute is not understood, it SHOULD be ignored. The **insertAfterMso**, **insertAfterQ**, **insertBeforeMso**, and **insertBeforeQ** attributes are mutually exclusive. If none of these attributes are specified, the controls SHOULD be appended to the existing set of controls, in the order they are defined in the XML. For example, consider the following XML fragment: \<tab id\="MyTab" insertBeforeQ\="x:OtherTab" label\="Custom Tab"\>   … \</tab\> In this example, a new custom tab with an identifier of "MyTab" is to be inserted before the custom tab with a qualified identifier of "x:OtherTab". The possible values for this attribute are defined by the **ST_QID** simple type, as specified in section 2.3.9.|
|**keytip** (keytip)|Specifies a **string** to be used as the suggested KeyTip for this control. The **keytip** and **getKeytip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically. For example, consider a button with KeyTip 'K', as follows: ![Button with Key Tip K](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img35.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" keytip\="K" /\> The possible values for this attribute are defined by the **ST_Keytip** simple type, as specified in section [2.3.7]().|
|**label** (label)|Specifies a **string** to be used as the label for this control. The **label** and **getLabel** attributes are mutually exclusive. If neither attribute is specified, no **label** SHOULD be displayed. For example, consider the following XML fragment: \<button id\="button" label\="Custom Button" /\> This specifies a custom **button** with a **label** of "Custom Button". The possible values for this attribute are defined by the **ST_String** simple type, as specified in section [2.3.11]().|
|**screentip** (screentip)|Specifies a **string** to be shown as the screentip for this control. The **screentip** and **getScreentip** attributes are mutually exclusive. If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all. For example, consider a button with a screentip, as follows: ![Button with screen tip string](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img36.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="This is the screentip" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**showImage** (show image)|Specifies whether this control displays an icon.  The **showImage** and **getShowImage** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon. For example, consider a button that does not display an icon, as follows: ![Button with no icon](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img37.png) This is specified using the following XML fragment: \<button id\="button" showImage\="false"    label\="Button with no icon" /\>  The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**showLabel** (show label)|Specifies whether this control SHOULD display its label.   The **showLabel** and **getShowLabel** attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label. For example, consider the following XML fragment: \<button id\="button" label\="Label" showLabel\="false"    imageMso\="HappyFace" /\> This specifies a **button** that has a **label**, but does not show it. Even though the **label** is hidden, it is provided to accessibility tools. The possible values for this attribute are defined by the XML schema **boolean** datatype.|
|**supertip** (supertip)|Specifies a **string** to be shown as the supertip of the control. The **supertip** and **getSupertip** attributes are mutually exclusive. If neither attribute is specified no supertip for this control SHOULD be shown. For example, consider a control with a supertip, as follows: ![Button with super tip string](D:\Documentation\MD\Open-and-Save-MD-document\Open-and-Save-MD-document\Output\Document-100_images\Document-100_img38.png) This is specified using the following XML fragment: \<button id\="button" imageMso\="HappyFace" label\="Button"   size\="large" screentip\="Screentip"   supertip\="This is the supertip string" /\> The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**tag** (tag)|Specifies an arbitrary **string** that can be used to hold data or identify the control. The contents of this attribute SHOULD be passed to any callback functions specified on this control. If this attribute is omitted, the control's **tag** value SHOULD default to an empty **string**. For example, consider the following XML fragment: \<button id\="button" label\="Button" tag\="123456"    onAction\="ButtonClicked" /\> This specifies a **button** with a **tag** value of "123456", which is passed to the **ButtonClicked** callback function. The possible values for this attribute are defined by the **ST_String** simple type, as specified in section 2.3.11.|
|**visible** (control visibility)|Specifies the visibility state of the control. The **getVisible** and **visible** attributes are mutually exclusive. If these attributes are omitted, the control SHOULD default to being visible. For example, consider the following XML fragment: \<tab idMso\="TabHome" visible\="false" /\> In this example, the built\-in tab with an identifier of "TabHome" is hidden. The possible values for this attribute are defined by the XML schema **boolean** datatype.|


The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_SplitButtonWithTitle"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_SplitButtonRestricted"\>

   \<xsd:sequence minOccurs\="0"\>

   \<xsd:choice minOccurs\="0"\>

   \<xsd:element name\="button" type\="CT_VisibleButton"/\>

   \<xsd:element name\="toggleButton" type\="CT_VisibleToggleButton"/\>

   \</xsd:choice\>

   \<xsd:element name\="menu" type\="CT_MenuWithTitle"/\>

   \</xsd:sequence\>

   \</xsd:extension\>

   \</xsd:complexContent\>

\</xsd:complexType\>

The following XML schema fragment defines the contents of this element:

\<xsd:complexType name\="CT_ToggleButton"\>

   \<xsd:complexContent\>

   \<xsd:extension base\="CT_ToggleButtonRegular"\>

   \<xsd:attributeGroup ref\="AG_SizeAttributes"/\>

   \</xsd:extension\>

   \</xsd:complexContent\>


### **Excel 2007 XE "idMso tables:Excel 2007"  XE "Tables:idMso table – Excel 2007"** 
|**Control Type**|**Label**|
|:---|:---|
|button|Spelling...|
|button|Save|
|button|Print|
|button|Chart...|
|button|New|
|button|Copy|
|button|Cut|
|button|Paste|
|button|Open|
|toggleButton|Zoom|
|button|Repeat|
|toggleButton|Double Underline|
|button|Close|
|toggleButton|Format Painter|
|button|Print Preview|
|toggleButton|Bold|
|toggleButton|Italic|
|toggleButton|Underline|
|button|Dark Shading|
|toggleButton|Align Left|
|toggleButton|Align Right|
|toggleButton|Center|
|toggleButton|Justify|
|gallery|Undo|
|gallery|Redo|
|toggleButton|Top Border|
|toggleButton|Bottom Border|
|toggleButton|Left Border|
|toggleButton|Right Border|
|button|Inside Borders|
|button|Outside Borders|
|button|No Border|
|button|Group|
|button|Ungroup|
|button|Bring to Front|
|button|Send to Back|
|button|Bring Forward|
|button|Send Backward|
|toggleButton|Full Screen|
|toggleButton|Select Objects|
|button|Record Macro...|
|button|Macros|
|button|Flip Horizontal|
|button|Flip Vertical|
|button|Rotate Right 90°|
|button|Rotate Left 90°|
|toggleButton|Freeform|
|toggleButton|Edit Points|
|button|Edit Box|
|button|Check Box|
|button|Combo Box|
|button|Property Sheet|
|toggleButton|Lock|
|button|Sum|
|button|Edit Cell Styles|
|button|Camera|
|button|Button|
|button|Calculator|
|toggleButton|Strikethrough|
|button|Delete Cells...|
|button|Insert Cells...|
|button|Arrange All|
|button|New Window|
|button|Accept/Reject Changes|
|button|Symbol...|
|button|Replace...|
|button|Previous Page|
|button|Next Page|
|toggleButton|Vertical Text Box|
|button|Regroup|
|button|Set Print Area|
|button|Paste Formatting|
|button|Paste Values|
|button|Right|
|button|Down|
|button|Equal Sign|
|button|Plus Sign|
|button|Minus Sign|
|button|Multiplication Sign|
|button|Division Sign|
|button|Exponentiation Sign|
|button|Left Parenthesis|
|button|Right Parenthesis|
|button|Colon|
|button|Comma|
|button|Percent Sign|
|button|Dollar Sign|
|button|Insert Function...|
|button|Constrain Numeric|
|button|Light Shading|
|button|Accounting Number Format|
|button|Percent Style|
|button|Comma Style|
|button|Increase Decimal|
|button|Decrease Decimal|
|toggleButton|Merge \& Center|
|button|Increase Font Size|
|button|Decrease Font Size|
|toggleButton|Vertical Text|
|toggleButton|Rotate Text Up|
|toggleButton|Rotate Text Down|
|button|Distribute Horizontally|
|toggleButton|Scribble|
|button|Show Outline Symbols|
|button|Select Visible Cells|
|button|Select Current Region|
|button|Freeze Panes|
|button|Zoom In|
|button|Zoom Out|
|button|Option Button|
|button|Scroll Bar|
|button|List Box|
|button|Remove Dependent Arrows|
|button|Trace Dependents|
|button|Remove Precedent Arrows|
|button|Remove Arrows|
|button|Update File|
|button|Toggle Read Only|
|button|AutoFilter|
|button|Refresh|
|button|Field Settings|
|button|Show Report Filter Pages...|
|button|Show Detail|
|button|Trace Error|
|button|Hide Detail|
|button|Distribute Vertically|
|button|Group Box|
|button|Spinner|
|button|Tab Order...|
|button|Run Dialog|
|button|Combination List\-Edit|
|button|Combination Drop\-Down Edit|
|button|Label|
|button|Trace Precedents|
|button|Code|
|button|Insert Page Break|
|button|Parameters|
|button|Row Height...|
|button|Column Width...|
|button|Object...|
|toggleButton|Snap to Grid|
|button|Align Left|
|button|Align Right|
|button|Align Top|
|button|Align Bottom|
|button|Align Center|
|button|Align Middle|
|toggleButton|Clip Art...|
|button|Free Rotate|
|toggleButton|Yoko\-Gumi|
|toggleButton|Normal|
|toggleButton|Page Break Preview|
|toggleButton|Crop|
|button|Close All|
|button|Save As|
|button|View Document Properties...|
|button|Copy as Picture...|
|button|Paste Special...|
|button|Select All|
|button|Go To...|
|button|Edit Links to Files|
|button|Header \& Footer...|
|button|Bullets and Numbering...|
|button|AutoFormat...|
|button|Merge Cells|
|button|Split Cells...|
|button|Convert Text to Table...|
|button|Office Clipboard...|
|button|Create Microsoft Office Outlook Task|
|button|Minimize|
|button|Restore|
|button|Close|
|button|Save Workspace...|
|button|Delete Sheet|
|button|Move or Copy Sheet...|
|checkBox|Formula Bar|
|button|Insert Sheet|
|button|Format Cells...|
|button|Goal Seek...|
|button|Scenario Manager...|
|button|Form...|
|button|Subtotal|
|button|Data Table...|
|button|Consolidate...|
|button|Hide|
|button|Unhide...|
|button|Up|
|button|Left|
|button|Across Worksheets...|
|button|Series...|
|button|Justify|
|button|Clear Formats|
|button|Clear Contents|
|button|Clear Comments|
|button|Paste Names...|
|button|Create from Selection...|
|button|Apply Names...|
|button|AutoFit Row Height|
|button|Hide Rows|
|button|Unhide Rows|
|button|AutoFit Column Width|
|button|Hide Columns|
|button|Unhide Columns|
|button|Default Width...|
|button|Clear|
|toggleButton|Superscript|
|toggleButton|Subscript|
|button|Close|
|toggleButton|Format Painter|
|toggleButton|Print Preview|
|button|Pick Up Style|
|button|Apply Style|
|toggleButton|Bold|
|toggleButton|Italic|
|toggleButton|Underline|
|toggleButton|Align Left|
|toggleButton|Align Right|
|toggleButton|Center|
|toggleButton|Justify|
|gallery|Undo|
|gallery|Redo|
|button|Promote|
|button|Demote|
|button|Move Up|
|button|Move Down|
|button|Expand|
|button|Collapse|
|toggleButton|Text Box|
|button|Find...|
|toggleButton|Top Border|
|toggleButton|Bottom Border|
|toggleButton|Left Border|
|toggleButton|Right Border|
|toggleButton|Inside Borders|
|toggleButton|Outside Borders|
|toggleButton|No Border|
|button|Group|
|button|Ungroup|
|button|Bring to Front|
|button|Send to Back|
|button|Bring Forward|
|button|Send Backward|
|button|Full Screen|
|checkBox|Ruler|
|toggleButton|Select Objects|
|button|Macros|
|button|Flip Horizontal|
|button|Flip Vertical|
|button|Rotate Right 90°|
|button|Rotate Left 90°|
|group|Drawing|
|toggleButton|Edit Points|
|button|Grid Settings...|
|button|Property Sheet|
|toggleButton|Show Text Formatting|
|toggleButton|Strikethrough|
|button|Arrange All|
|button|New Window|
|button|Symbol...|
|button|Replace...|
|button|Previous Page|
|button|Next Page|
|toggleButton|Vertical Text Box|
|button|Redo|
|button|Regroup|
|button|Increase Font Size|
|button|Decrease Font Size|
|button|Object...|
|toggleButton|Snap to Grid|
|button|Find Next|
|button|Duplicate|
|button|New Slide|
|toggleButton|Clip Art...|
|button|Create Handouts in Microsoft Office Word|
|toggleButton|Shadow|
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|||
|button|Tab|
|button|Cascade|
|toggleButton|Inside Horizontal Border|
|toggleButton|Inside Vertical Border|
|toggleButton|Diagonal Down Border|
|toggleButton|Diagonal Up Border|
|toggleButton|Left\-to\-Right|
|toggleButton|Right\-to\-Left|
|button|Check Box|
|button|Text Box|
|button|Command Button|
|button|Option Button|
|button|List Box|
|button|Combo Box|
|button|Toggle Button|
|button|Spin Button|
|button|Scroll Bar|
|button|Label|
|button|Convert...|
|button|Edit Comment|
|toggleButton|Draw Table|
|toggleButton|Eraser|
|toggleButton|Align Top|
|toggleButton|Center Vertically|
|toggleButton|Align Bottom|
|button|Distribute Columns|
|button|Distribute Rows|
|button|Image|
|button|Delete Rows|
|button|Delete Columns|
|button|Shadow On/Off|
|button|Set AutoShape Defaults|
|button|E\-mail|
|button|New|
|button|Quick Print|
|button|Picture...|
|dropDown|Pen Weight|
|toggleButton|View Gridlines|
|gallery|Pen Color|
|toggleButton|Straight Arrow Connector|
|toggleButton|Elbow Arrow Connector|
|button|Delete|
|toggleButton|Handout Master|
|toggleButton|Notes Master|
|toggleButton|Reuse Slides...|
|button|Slides from Outline...|
|button|Movie from Organizer...|
|button|Movie from File...|
|button|Sound from Clip Organizer...|
|button|Sound from File...|
|button|Play CD Audio Track...|
|button|Replace Fonts...|
|button|Toggle Case|
|toggleButton|B \& W Automatic|
|toggleButton|B \& W|
|toggleButton|B \& W Black with Grayscale Fill|
|toggleButton|B \& W Black with White Fill|
|toggleButton|B \& W Don't Show|
|toggleButton|B \& W Gray with White Fill|
|toggleButton|B \& W Grayscale|
|toggleButton|B \& W Inverse Grayscale|
|toggleButton|B \& W White|
|toggleButton|B \& W Light Grayscale|
|button|Record Narration|
|button|Set Up Slide Show...|
|button|Paste as Hyperlink|
|toggleButton|Distributed|
|button|Reset Character Formatting|
|toggleButton|Set Transparent Color|
|button|Custom Slide Show|
|button|Fit to Page|
|button|Record Sound...|
|button|Duplicate Selected Slides|
|button|Action|
|button|Previous|
|button|Next|
|button|Break Link|
|button|Change Link|
|button|Update Links|
|button|Lower Baseline|
|button|Raise Baseline|
|button|Slide Show in a Window|
|button|Hangul Hanja Conversion|
|toggleButton|2 Slides|
|toggleButton|3 Slides|
|toggleButton|6 Slides|
|toggleButton|Slide Outline|
|button|Go To...|
|button|Increase Indent|
|button|Decrease Indent|
|button|Preview|
|toggleButton|4 Slides|
|toggleButton|9 Slides|
|button|Macro Security|
|button|Web Page Preview|
|button|Table...|
|button|Insert Above|
|button|Insert Below|
|button|Insert Left|
|button|Insert Right|
|button|COM Add\-Ins...|
|toggleButton|Normal|
|button|Web Options...|
|toggleButton|Left\-to\-Right|
|toggleButton|Right\-to\-Left|
|button|Next Pane|
|button|Move Split|
|toggleButton|Set Left\-to\-Right Table|
|toggleButton|Set Right\-to\-Left Table|
|button|Resume Slide Show|
|button|Select Multiple Objects|
|button|More Colors...|
|button|Fit|
|button|Resize|
|toggleButton|Back To Color View|
|toggleButton|Grayscale|
|toggleButton|High Contrast|
|toggleButton|Pure Black and White|
|dropDown|Print What|
|button|Expand|
|toggleButton|1 Slide|
|toggleButton|Preserve|
|button|Rename|
|button|Show Outline|
|button|Bullets and Numbering...|
|button|Check Out|
|button|Check In|
|toggleButton|Landscape|
|toggleButton|Portrait|
|button|Reset|
|button|Compress Pictures...|
|button|Delete|
|button|Next|
|button|Previous|
|toggleButton|Show Markup|
|button|Delete All Markup on the Current Slide|
|button|Translate...|
|checkBox|View Gridlines|
|button|New Photo Album...|
|button|Edit Photo Album...|
|button|Scale Drawing|
|toggleButton|Research...|
|button|Internet Fax|
|button|Package for CD|
|button|View Version History|
|button|More Ink Colors...|
|button|Contact Us...|
|toggleButton|Unrestricted Access|
|toggleButton|Restricted Access|
|button|View Permission|
|button|Thesaurus...|
|button|Start Inking|
|button|Check for Updates|
|toggleButton|Eraser|
|button|Manage Credentials|
|button|Browse for Themes...|
|button|Insert Layout|
|toggleButton|View Signatures|
|button|View Workflow Tasks|
|button|Workflows|
|gallery|Themes|
|button|Label|
|button|Barcode|
|gallery|Quick Styles|
|gallery|Quick Layout|
|button|Save As Template|
|menu|Axis Titles|
|menu|Axes|
|menu|Gridlines|
|button|Format Selection|
|comboBox|Chart Elements|
|button|From Current Slide|
|gallery|Bullets|
|gallery|Numbering|
|gallery|Line Spacing|
|gallery|New Slide|
|gallery|Layout|
|tab|Format|
|tab|Format|
|gallery|Shapes|
|gallery|Change Shape|
|gallery|Texture|
|gallery|Quick Styles|
|menu|Orientation|
|menu|Server|
|menu|Send|
|tab|Insert|
|tab|View|
|group|Font|
|group|Paragraph|
|group|Proofing|
|group|Illustrations|
|group|Insert Shapes|
|group|Page Setup|
|group|Comments|
|group|Size|
|group|Draw Borders|
|tab|Design|
|tab|Animations|
|tab|Slide Show|
|group|Slides|
|group|Arrange|
|group|Media Clips|
|group|Themes|
|group|Background|
|group|Preview|
|group|Animations|
|group|Transition to This Slide|
|group|Start Slide Show|
|group|Set Up|
|group|Shape Styles|
|tab|Review|
|group|Chart Layouts|
|group|Chart Styles|
|group|Axes|
|group|Insert|
|gallery|Preset|
|gallery|Preset|
|gallery|3\-D Rotation|
|tab|Design|
|tab|Format|
|tab|Design|
|tab|Layout|
|tab|Format|
|gallery|Shape Fill|
|gallery|Picture Border|
|button|Inspect Document|
|button|Clear Formatting|
|group|Controls|
|group|Zoom|
|button|Publish Slides|
|checkBox|Use Presenter View|
|gallery|Arrows|
|gallery|Dashes|
|gallery|Weight|
|tab|Layout|
|group|Alignment|
|group|Adjust|
|group|Size|
|tab|Slide Master|
|group|Table Styles|
|group|Rows \& Columns|
|menu|Align|
|splitButton|Movie|
|splitButton|Sound|
|gallery|Rotate|
|menu|Select|
|dropDown|Animate:|
|gallery|Transition Scheme|
|dropDown|Transition Speed:|
|gallery|Font Color|
|gallery|Columns|
|tab|Home|
|gallery|Chart Title|
|gallery|Primary Horizontal Axis Title|
|gallery|Primary Vertical Axis Title|
|gallery|Depth Axis Title|
|gallery|Legend|
|gallery|Data Labels|
|gallery|Primary Horizontal Gridlines|
|gallery|Primary Vertical Gridlines|
|gallery|Depth Gridlines|
|gallery|Primary Horizontal Axis|
|gallery|Primary Vertical Axis|
|gallery|Depth Axis|
|gallery|Data Table|
|gallery|Trendline|
|gallery|Error Bars|
|gallery|Lines|
|gallery|Up/Down Bars|
|gallery|Plot Area|
|gallery|Chart Wall|
|gallery|Chart Floor|
|button|Add Shape|
|button|Larger|
|button|Smaller|
|button|Reset Graphic|
|toggleButton|Text Pane|
|toggleButton|Edit in 2\-D|
|gallery|Change Layout|
|button|More Layouts...|
|gallery|Quick Styles|
|gallery|Change Colors|
|gallery|Soft Edges|
|gallery|Glow|
|gallery|Gradient|
|gallery|Shadow|
|gallery|WordArt|
|gallery|Transform|
|gallery|Colors|
|group|Layouts|
|group|SmartArt Styles|
|group|Create Graphic|
|group|Reset|
|group|Size|
|button|More Themes on Microsoft Office Online...|
|tab|Add\-Ins|
|menu|Edit Shape|
|button|Content|
|button|Text|
|button|Chart|
|button|Table|
|button|SmartArt|
|button|Media|
|button|Clip Art|
|button|Text |
|checkBox|Title|
|checkBox|Footers|
|gallery|Table Styles|
|button|Publish as PDF or XPS|
|button|OpenDocument Presentation|
|button|More Controls...|
|group|Code|
|tab|Developer|
|button|Apply To All|
|checkBox|On Mouse Click|
|button|Preview|
|group|Editing|
|group|Clipboard|
|group|Tables|
|group|Links|
|group|Barcode|
|dropDown|Transition Sound:|
|button|Picture...|
|button|From Beginning|
|menu|Switch Windows|
|button|Create New Theme Colors...|
|button|Create New Theme Fonts...|
|button|More Gradients...|
|button|Shadow Options...|
|toggleButton|Align Selected Objects|
|toggleButton|Align to Slide|
|button|Align Left|
|button|Align Right|
|button|Align Top|
|button|Align Bottom|
|button|Align Center|
|button|Align Middle|
|button|Distribute Horizontally|
|button|Distribute Vertically|
|menu|Custom Slide Show|
|dropDown|Resolution:|
|checkBox|Use Rehearsed Timings|
|dropDown|Show Presentation On:|
|group|Monitors|
|gallery|Fonts|
|gallery|Effects|
|toggleButton|Properties|
|tab|Print Preview|
|group|Print|
|group|Preview|
|tab|Options|
|tab|Options|
|group|Play|
|group|Movie Options|
|group|Sound Options|
|checkBox|Hide During Show|
|checkBox|Loop Until Stopped|
|dropDown|Play Sound:|
|gallery|Slide Show Volume|
|checkBox|Play Full Screen|
|checkBox|Rewind Movie After Playing|
|splitButton|Borders|
|toggleButton|Create Document Workspace|
|button|Document Management Server|
|toggleButton|Document Management Information|
|button|Customize Quick Access Toolbar...|
|menu|Prepare|
|toggleButton|Mark as Final|
|button|Add a Digital Signature|
|checkBox|Hide Background Graphics|
|gallery|Change Case|
|splitButton|Delete|
|group|Merge|
|menu|Justify|
|splitButton|Text Box|
|toggleButton|Horizontal Text Box|
|button|Properties|
|gallery|Handout Orientation|
|menu|Slides Per Page|
|checkBox|Slide Image|
|checkBox|Body|
|checkBox|Date|
|checkBox|Page Number|
|checkBox|Header|
|checkBox|Footer|
|tab|Handout Master|
|tab|Notes Master|
|group|Placeholders|
|group|Edit Theme|
|group|Close|
|group|Edit Master|
|group|Master Layout|
|tab|Grayscale|
|tab|Black And White|
|group|Change Selected Object|
|group|Select|
|gallery|Brightness|
|gallery|Contrast|
|gallery|Shading|
|button|Add Shape After|
|button|Add Shape Before|
|button|Add Shape Above|
|button|Add Shape Below|
|button|Add Assistant|
|button|Reset Slide Theme Colors|
|button|Switch Row/Column|
|button|Edit Data...|
|button|Refresh Data|
|button|Change Chart Type...|
|group|Data|
|group|Type|
|group|Table Size|
|gallery|Cell Margins|
|button|Content (Vertical)|
|button|3\-D Rotation Options...|
|button|3\-D Options...|
|gallery|Background Styles|
|gallery|Text Direction|
|group|Table Style Options|
|checkBox|Header Row|
|checkBox|First Column|
|checkBox|Total Row|
|checkBox|Last Column|
|checkBox|Banded Rows|
|checkBox|Banded Columns|
|toggleButton|Selection Pane...|
|button|Left Hanging|
|button|Right Hanging|
|button|Both|
|button|Standard|
|toggleButton|Right to Left|
|button|Custom Margins...|
|checkBox|Message Bar|
|gallery|Other Theme Fills|
|menu|Layout|
|tab|Home|
|gallery|Table|
|toggleButton|Justify|
|toggleButton|Justify Low|
|toggleButton|Distribute|
|button|Excel Spreadsheet|
|tab|Options|
|checkBox|Automatically After:|
|gallery|Slide Orientation|
|group|Menu Commands|
|group|Toolbar Commands|
|group|Ink|
|tab|Pens|
|group|Pens|
|group|Close|
|toggleButton|Ballpoint Pen|
|toggleButton|Felt Tip Pen|
|toggleButton|Highlighter|
|button|Save Current Theme...|
|gallery|Align Text|
|gallery|Character Spacing|
|button|Reset to Match Style|
|button|3\-D Rotation...|
|button|Size and Position...|
|button|Convert to Freeform|
|tab|Design|
|gallery|Convert to SmartArt|
|button|More SmartArt Graphics...|
|gallery|Reflection|
|gallery|Recolor|
|button|Promote|
|button|Demote|
|gallery|Cell Bevel|
|gallery|Table Background|
|button|More Title Options...|
|button|More Legend Options...|
|button|More Data Label Options...|
|button|More Primary Horizontal Axis Title Options...|
|button|More Primary Vertical Axis Title Options...|
|button|More Secondary Horizontal Axis Title Options...|
|button|More Secondary Vertical Axis Title Options...|
|button|More Depth Axis Title Options...|
|button|More Primary Horizontal Gridlines Options...|
|button|More Primary Vertical Gridlines Options...|
|button|More Secondary Horizontal Gridlines Options...|
|button|More Secondary Vertical Gridlines Options...|
|button|More Depth Gridlines Options...|
|button|More Primary Horizontal Axis Options...|
|button|More Primary Vertical Axis Options...|
|button|More Secondary Horizontal Axis Options...|
|button|More Secondary Vertical Axis Options...|
|button|More Depth Axis Options...|
|button|More Data Table Options...|
|button|More Trendline Options...|
|button|More Error Bars Options...|
|button|More Up/Down Bars Options...|
|button|More Plot Area Options...|
|button|More Walls Options...|
|button|More Floor Options...|
|gallery|Secondary Horizontal Axis Title|
|gallery|Secondary Vertical Axis Title|
|gallery|Secondary Horizontal Gridlines|
|gallery|Secondary Vertical Gridlines|
|gallery|Secondary Horizontal Axis|
|gallery|Secondary Vertical Axis|
|group|Custom Toolbars|
|dropDown|Play Movie:|
|splitButton|Bring to Front|
|splitButton|Send to Back|
|menu|Group|
|toggleButton|Color|
|button|PowerPoint 97\-2003 Presentation|
|splitButton|Save As Other Format|
|splitButton|Preview and Print|
|menu|Restrict Permission|
|button|Document Panel|
|group|Modify|
|gallery|Bevel|
|gallery|Bevel|
|button|Clear Table|
|group|Table|
|group|Cell Size|
|menu|Effects|
|gallery|More Glow Colors|
|gallery|More Variations|
|button|More Colors...|
|button|More Colors...|
|button|Add Bullet|
|checkBox|Lock Aspect Ratio|
|button|Picture|
|splitButton|Insert Placeholder|
|button|More Border Colors...|
|button|More Fill Colors...|
|button|Change Picture...|
|group|WordArt Styles|
|gallery|Text Fill|
|gallery|Text Outline|
|button|More Outline Colors...|
|menu|Text Effects|
|gallery|Quick Styles|
|button|Clear WordArt|
|button|Picture...|
|gallery|Gradient|
|button|More Gradients...|
|gallery|Texture|
|gallery|Dashes|
|button|More Lines...|
|gallery|Weight|
|gallery|Shadow|
|button|Shadow Options...|
|button|3\-D Options...|
|gallery|3\-D Rotation|
|button|3\-D Rotation Options...|
|gallery|Glow|
|gallery|More Glow Colors|
|button|More Colors...|
|gallery|Reflection|
|menu|Shape Effects|
|toggleButton|Loop Until Next Sound|
|group|Current Selection|
|group|Labels|
|gallery|Bevel|
|button|Picture Corrections Options...|
|splitButton|Add Shape Options|
|gallery|Notes Page Orientation|
|group|Format|
|gallery|Color|
|button|More Options...|
|button|More Options...|
|button|More Columns...|
|button|Reset Slide Background|
|dropDown|Play Track:|
|group|Shapes|
|group|Text|
|gallery|Picture Border|
|group|Close|
|group|Page Setup|
|group|Page Setup|
|group|Placeholders|
|splitButton|Replace...|
|menu|Select|
|menu|Delete|
|group|Set Up|
|menu|Options|
|button|Delete All Markup in the Presentation|
|splitButton|Paste|
|group|Picture Styles|
|gallery|Quick Styles|
|gallery|Shadow|
|gallery|Glow|
|gallery|Soft Edges|
|gallery|Reflection|
|gallery|3\-D Rotation|
|button|Close Ink Tools|
|group|Show/Hide|
|group|Window|
|checkBox|View Gridlines|
|group|Presentation Views|
|group|Color/Grayscale|
|toggleButton|Encrypt Document|
|button|Format Text Effects...|
|button|More Rotation Options...|
|button|More Textures...|
|button|More Fill Colors...|
|button|Fit to Window|
|group|Page Setup|
|menu|View Direction|
|button|E\-mail as PDF Attachment|
|button|E\-mail as XPS Attachment|
|menu|Picture Effects|
|gallery|Change Shape|
|splitButton|Photo Album...|
|group|Background|
|group|Analysis|
|menu|Publish|
|button|Run Compatibility Checker|
|button|Picture...|
|button|Convert|
|button|Save As|
|button|PowerPoint Presentation|
|button|PowerPoint Show|
|button|Font...|
|button|Paragraph...|
|button|Page Setup...|
|gallery|Quick Styles|
|gallery|Shapes|
|gallery|Quick Styles|
|group|WordArt Styles|
|menu|Arrange|
|button|More Textures...|
|group|Macros|
|button|Find add\-ins for other file formats|
|group|Protect|
|menu|Protect Presentation|
|button|Size and Position...|
|button|Discard Check Out|
|menu|Document|



## ***imageMso Table XE "Custom UI control id table:imageMso table"  XE "Tables:imageMso table"*** 
|**imageMso**|
|:---|
|Spelling|
|FileSave|
|FilePrint|
|ZoomOnePage|
|ZoomPageWidth|
|Zoom100|
|TableInsert|
|ColumnsDialog|
|Numbering|
|Bullets|
|PageOrientationPortraitLandscape|
|OutdentClassic|
|IndentClassic|
|DrawingInsert|
|ChartInsert|
|FileNew|
|Copy|
|Cut|
|Paste|
|FileOpen|
|EnvelopesAndLabelsDialog|
|ZoomPrintPreviewExcel|
|PenComment|
|Folder|
|Repeat|
|UpArrow2|
|RightArrow2|
|DownArrow2|
|LeftArrow2|
|Clear|
|Breakpoint|
|Piggy|
|Superscript|
|Subscript|
|HappyFace|
|UnderlineDouble|
|UnderlineWords|
|FontSizeIncreaseWord|
|FontSizeDecreaseWord|
|_0|
|_1|
|_2|
|_3|
|_4|
|_5|
|_6|
|_7|
|_8|
|_9|
|A|
|B|
|C|
|D|
|E|
|F|
|G|
|H|
|I|
|J|
|K|
|L|
|M|
|N|
|O|
|P|
|Q|
|R|
|S|
|T|
|U|
|V|
|W|
|X|
|Y|
|Z|
|FileClose|
|TableAutoFormat|
|FormatPainter|
|FilePrintPreview|
|PickUpStyle|
|PasteApplyStyle|
|Bold|
|Italic|
|Underline|
|DarkShading|
|ParagraphMarks|
|AlignLeft|
|AlignRight|
|AlignCenter|
|AlignJustify|
|ContextHelp|
|HeaderFooterPageNumberInsert|
|Undo|
|Redo|
|ControlLine|
|ControlRectangle|
|OutlinePromote|
|OutlineDemote|
|OutlineMoveUp|
|OutlineMoveDown|
|OutlineDemoteToBodyText|
|OutlineExpand|
|OutlineCollapse|
|TextBoxInsert|
|FileFind|
|FindDialog|
|TableExcelSpreadsheetInsert|
|AutoFormat|
|BorderTop|
|BorderBottom|
|BorderLeft|
|BorderRight|
|BorderInside|
|BorderOutside|
|BorderNone|
|MailMergeGoToFirstRecord|
|MailMergeGoToPreviousRecord|
|MailMergeGoToNextRecord|
|MailMergeGotToLastRecord|
|MailMergeMergeToDocument|
|MailMergeMergeToPrinter|
|MailMergeAutoCheckForErrors|
|DataFormSource|
|MailMergeResultsPreview|
|ObjectsGroup|
|ObjectsUngroup|
|ObjectBringToFront|
|ObjectSendToBack|
|AboveText|
|BehindText|
|ObjectBringForward|
|ObjectSendBackward|
|Magnifier|
|PrintPreviewShrinkOnePage|
|MultiplePages|
|ViewFullScreenView|
|ViewRulerPowerPoint|
|VoiceInsert|
|ObjectsSelect|
|TableFind|
|MacroRecord|
|MacroRecorderPause|
|MacroPlay|
|ObjectFlipHorizontal|
|ObjectFlipVertical|
|ObjectRotateRight90|
|ObjectRotateLeft90|
|ShapeFreeform|
|GroupDrawing|
|ObjectEditPoints|
|CalloutOptions|
|SortUp|
|SortDown|
|TableDesign|
|DataFormAddRecord|
|DataFormDeleteRecord|
|FieldsUpdate|
|DatabaseInsert|
|GridSettings|
|WordPicture|
|FormControlEditBox|
|FormControlCheckBox|
|FormControlComboBox|
|PropertySheet|
|FieldShading|
|ViewDraftView|
|Lock|
|AutoSum|
|MasterDocumentShow|
|MasterDocumentCreateSubdocument|
|MasterDocumentUnlinkSubdocument|
|MasterDocumentInsertSubdocument|
|MasterDocumentSplitSubdocuments|
|MasterDocumentMergeSubdocuments|
|MasterDocumentLockSubdocument|
|HeaderOrFooterShow|
|HeaderFooterPreviousSection|
|HeaderFooterNextSection|
|AlignDialog|
|MailMergeDocument|
|MergeOptions|
|MailMergeHelper|
|PageSetupDialog|
|BodyTextHide|
|HeaderFooterLinkToPrevious|
|OutlineShowFirstLineOnly|
|OutlineShowTextFormatting|
|FontDialog|
|StylesDialogClassic|
|RoutingSlip|
|FootnoteInsert|
|MicrosoftExcel|
|MicrosoftAccess|
|Schedule|
|MicrosoftVisualFoxPro|
|MicrosoftPowerPoint|
|MicrosoftPublisher|
|MicrosoftProject|
|SadFace|
|Pushpin|
|Camera|
|FormControlButton|
|Calculator|
|ViewPrintLayoutView|
|FieldCodes|
|DropCapOptionsDialog|
|Strikethrough|
|TextSmallCaps|
|CellsDelete|
|TableRowsDelete|
|TableColumnsDelete|
|CellsInsertDialog|
|TableRowsInsertWord|
|QueryInsertColumns|
|WindowsArrangeAll|
|MarginsAdjust|
|ViewGridlinesWord|
|SubdocumentOpen|
|WindowSplit|
|WindowNew|
|LegalBlackline|
|ReviewAcceptOrRejectChangeDialog|
|TextAllCaps|
|PictureDisassemble|
|SymbolInsert|
|ChangeCaseDialogClassic|
|FontSizeDecrease1Point|
|FontSizeIncrease1Point|
|Repaginate|
|ReplaceDialog|
|StartOfLine|
|EndOfLine|
|PagePrevious|
|PageNext|
|TextBoxInsertVertical|
|StartOfDocument|
|EndOfDocument|
|Grammar|
|FileCloseOrCloseAll|
|TextToOrFromTable|
|TableRowsOrColumnsOrCellsInsert|
|TableRowsOrColumnsOrCellsDelete|
|RedoOrRepeat|
|ObjectsRegroup|
|_3DStyle|
|TipWizardHelp|
|AutoFormatChange|
|AddressBook|
|Reply|
|ReplyAll|
|Forward|
|MailMove|
|MailDelete|
|MessagePrevious|
|MessageNext|
|CheckNames|
|MailSelectNames|
|PrintAreaSetPrintArea|
|PasteFormatting|
|FillRight|
|FillDown|
|EqualSign|
|PlusSign|
|MinusSign|
|MultiplicationSign|
|DivisionSign|
|ExponentiationSign|
|ParenthesisLeft|
|ParenthesisRight|
|ColonSign|
|CommaSign|
|PercentSign|
|DollarSign|
|FunctionWizard|
|AsianLayoutCharacterScaling|
|ConstrainNumeric|
|LightShading|
|AccountingFormat|
|PercentStyle|
|CommaStyle|
|DecimalsIncrease|
|DecimalsDecrease|
|MergeCenter|
|FontSizeIncrease|
|FontSizeDecrease|
|TextOrientationVertical|
|TextOrientationRotateUp|
|TextOrientationRotateDown|
|AlignDistributeHorizontallyClassic|
|ShapeScribble|
|ChartAreaChart|
|Chart3DBarChart|
|Chart3DColumnChart|
|Chart3DPieChart|
|ChartRadarChart|
|OutlineSymbolsShowHide|
|TableSelectVisibleCells|
|SelectCurrentRegion|
|FreezePanes|
|ZoomIn|
|ZoomOut|
|FormControlRadioButton|
|FormControlScrollBar|
|FormControlListBox|
|TraceDependentRemoveArrows|
|TraceDependents|
|TracePrecedentsRemoveArrows|
|TraceRemoveAllArrows|
|FileUpdate|
|ReadOnly|
|AutoFilterClassic|
|Refresh|
|PivotTableFieldSettings|
|PivotTableShowPages|
|OutlineShowDetail|
|TraceError|
|OutlineHideDetail|
|AlignDistributeVerticallyClassic|
|FormControlGroupBox|
|FormControlSpinner|
|TabOrder|
|RunDialog|
|FormControlCombinationListEdit|
|FormControlCombinationDropDownEdit|
|FormControlLabel|
|Delete|
|Fish|
|Coffee|
|Heart|
|Diamond|
|Spade|
|Club|
|ViewSheetGridlines|
|TracePrecedents|
|Info|
|CodeEdit|
|InsertDialog|
|ApplyFilter|
|DatasheetView|
|SortAndFilterAdvanced|
|ControlSubFormReport|
|FieldList|
|ViewsFormView|
|Grouping|
|AdpPrimaryKey|
|ControlBoundObjectFrame|
|ControlUnboundObjectFrame|
|PageBreakInsertOrRemove|
|PrintSetupDialog|
|CreateFormInDesignView|
|CreateQueryFromWizard|
|CreateReportInDesignView|
|MacroConditions|
|MacroNames|
|ControlToggleButton|
|DatabaseRelationships|
|TableIndexes|
|ViewsAdpDiagramSqlView|
|QueryTableNamesShowHide|
|QueryShowTable|
|QuerySelectQueryType|
|QueryCrosstab|
|QueryMakeTable|
|QueryUpdate|
|QueryAppend|
|QueryDelete|
|QueryParameters|
|RecordsSaveRecord|
|GoToNewRecord|
|RowHeight|
|ColumnWidth|
|RecordsFreezeColumns|
|GridlinesGallery|
|OleObjectctInsert|
|ControlToolboxOutlook|
|SnapToGrid|
|SizeToFit|
|PageHeaderOrFooterShowHide|
|FormHeaderOrFooterShowHide|
|First10RecordsPreview|
|ControlSpecialEffectRaised|
|ControlSpecialEffectSunken|
|AutoDial|
|FindNext|
|PasteDuplicate|
|DatabasePermissions|
|ControlAlignToGrid|
|ControlSpecialEffectFlat|
|CreateTableInDesignView|
|MacroDefault|
|ModuleInsert|
|FilterToggleFilter|
|FilterClearAllFilters|
|Head|
|ReminderSound|
|CreateModule|
|RelationshipsDirectRelationships|
|RelationshipDesignAllRelationships|
|ControlWizards|
|MergeToWord|
|FilterAdvancedByForm|
|CreateMacro|
|AutoFormatWizard|
|PrintPreviewZoomTwoPages|
|FilterBySelection|
|RecordsDeleteRecord|
|QueryBuilder|
|DatabaseDocumenter|
|DatabaseAnalyzePerformance|
|DatabaseAnalyzeTable|
|ObjectsAlignLeft|
|ObjectsAlignRight|
|ObjectsAlignTop|
|ObjectsAlignBottom|
|ObjectsAlignCenterHorizontal|
|ObjectsAlignMiddleVertical|
|SlideNew|
|ClipArtInsert|
|CreateHandoutsInWord|
|Shadow|
|ObjectRotateFree|
|ShapesMoreShapes|
|CopyToPersonalContacts|
|ParagraphSpacingIncrease|
|ParagraphSpacingDecrease|
|SlideMasterMasterLayout|
|OrganizationChartInsert|
|CollapseAll|
|OutlineExpandAll|
|CombineCharacters|
|DoubleStrikethrough|
|QueryInsertColumn|
|EncryptMessage|
|DigitallySignMessage|
|CreateMailRule|
|ViewNormalViewExcel|
|ViewPageBreakPreviewView|
|SlideHide|
|AnimationCustom|
|PictureCrop|
|SlideShowRehearseTimings|
|ViewSlideView|
|ViewOutlineView|
|ViewSlideSorterView|
|ViewNotesPageView|
|ViewSlideShowView|
|ViewSlideMasterView|
|FileCloseAll|
|FileSaveAs|
|SaveAll|
|AdvancedFileProperties|
|DocumentTemplate|
|FileExit|
|PasteSpecialDialog|
|SelectAll|
|GoTo|
|BookmarkInsert|
|FileLinksToFiles|
|ViewOnlineLayoutViewClassic|
|HeaderFooterInsert|
|FootnotesEndnotesShow|
|BreakInsertDialog|
|DateAndTimeInsert|
|NumberInsert|
|FieldInsert|
|CaptionInsert|
|CrossReferenceInsert|
|TextFromFileInsert|
|ParagraphDialog|
|BordersShadingDialog|
|TextDirectionOptionsDialog|
|BulletsAndNumberingBulletsDialog|
|AutoFormatDialog|
|SetLanguage|
|WordCount|
|AutoCorrect|
|EnvelopesAndLabels|
|LabelsDialog|
|MergeCells|
|SplitCells|
|TableRowSelect|
|TableColumnSelect|
|TableSelect|
|TableRepeatHeaderRows|
|ConvertTextToTable|
|TableFormulaDialog|
|TableSplitTable|
|ShowClipboard|
|TechnicalSupport|
|ImeDictionaryUpdate|
|OutlookTaskCreate|
|WindowMinimize|
|WindowRestore|
|WindowClose|
|WindowSaveWorkspace|
|SheetDelete|
|ViewFormulaBar|
|SheetInsert|
|FormatCellsDialog|
|DataFormExcel|
|OutlineSubtotals|
|Consolidate|
|WindowHide|
|WindowUnhide|
|FillUp|
|FillLeft|
|ClearFormats|
|NameCreateFromSelection|
|SheetProtect|
|ReviewProtectWorkbook|
|MacroRelativeReferences|
|Filter|
|SortClear|
|AdvancedFilterDialog|
|OutlineSettings|
|PrintPreviewClose|
|HeaderFooterClose|
|ZoomDialog|
|SortDialogClassic|
|ConvertTableToText|
|PictureInsertFromFilePowerPoint|
|ExchangeFolder|
|VisualBasicReferences|
|ViewCustomViews|
|SheetBackground|
|ChartEditDataSource|
|ChartPlacement|
|CalculateNow|
|ObjectEditDialog|
|ObjectFormatDialog|
|QueryRunQuery|
|ControlImage|
|RulerShowHide|
|GridShowHide|
|ContentsAndIndex|
|Help|
|PivotTableEnableSelection|
|PivotTableListFormulas|
|PivotTableSelectData|
|PivotTableSelectLabelAndData|
|PivotTableSelectLabel|
|CalculateSheet|
|FontColorMoreColorsDialog|
|FillEffects|
|TextOrientationAngleCounterclockwise|
|TextOrientationAngleClockwise|
|HyperlinkOpenExcel|
|OpenStartPage|
|WebGoBack|
|WebGoForward|
|AddToFavorites|
|BrowsePrevious|
|BrowseNext|
|BrowseSelector|
|SmartArtInsert|
|ShapeRerouteConnectors|
|ObjectNudgeUp|
|ObjectNudgeDown|
|ObjectNudgeLeft|
|ObjectNudgeRight|
|ShapeCurve|
|ShapeStraightConnector|
|ShapeElbowConnector|
|ObjectFillMoreColorsDialog|
|ObjectBorderOutlineColorMoreColorsDialog|
|LineStylesDialog|
|ArrowsMore|
|TextEffectAlignment|
|TextEffectTracking|
|WordArtVerticalText|
|WordArtEvenTextHeightClassic|
|ContrastMore|
|ContrastLess|
|BrightnessMore|
|BrightnessLess|
|ShadowNudgeUpClassic|
|ShadowNudgeDownClassic|
|ShadowNudgeLeftClassic|
|ShadowNudgeRightClassic|
|ObjectShadowColorMoreColorsDialog|
|HighImportance|
|LowImportance|
|AttachMenu|
|InviteAttendees|
|AcceptInvitation|
|DeclineInvitation|
|TentativeAcceptInvitation|
|NewContact|
|NewTask|
|NewAppointment|
|TextAlignLeft|
|TextAlignCenter|
|ShapeRectangle|
|ShapeRoundedRectangle|
|ShapeIsoscelesTriangle|
|ShapeOval|
|ShapeSmileyFace|
|ShapeDonut|
|ShapeLeftBrace|
|ShapeRightBrace|
|ShapeArc|
|ShapeLightningBolt|
|ShapeHeart|
|ShapeRightArrow|
|ShapeLeftArrow|
|ShapeUpArrow|
|ShapeDownArrow|
|ShapeRoundedRectangularCallout|
|ShapeStar|
|ShapeSeal8|
|ShapeSeal16|
|ShapeSeal24|
|TextAlignRight|
|TextAlignLetterJustify|
|TextAlignWordJustify|
|TextAlignStretchJustify|
|PictureReset|
|PictureRecolorAutomatic|
|PictureRecolorGrayscale|
|PictureRecolorBlackAndWhite|
|PictureRecolorWashout|
|TextWrappingSquare|
|TextWrappingTight|
|TextWrappingNoneClassic|
|TextWrappingEditWrapPoints|
|_3DEffectsOnOffClassic|
|_3DTiltDownClassic|
|_3DTiltUpClassic|
|_3DTiltLeftClassic|
|_3DTiltRightClassic|
|_3DExtrusionDirectionClassic|
|_3DLightingClassic|
|_3DSurfaceMaterialClassic|
|_3DExtrusionDepthNoneClassic|
|_3DExtrusionDepth36Classic|
|_3DExtrusionDepth72Classic|
|_3DExtrusionDepth144Classic|
|_3DExtrusionDepth288Classic|
|_3DExtrusionDepthInfinityClassic|
|_3DExtrusionPerspectiveClassic|
|_3DExtrusionParallelClassic|
|_3DLightingFlatClassic|
|_3DLightingNormalClassic|
|_3DLightingDimClassic|
|_3DSurfaceMatteClassic|
|_3DSurfacePlasticClassic|
|_3DSurfaceMetalClassic|
|_3DSurfaceWireFrameClassic|
|ObjectEditText|
|SnapToShapes|
|TextWrappingMenuClassic|
|WindowsArrangeIcons|
|PictureFormatDialog|
|ViewVisualBasicCode|
|RemoveFromCalendar|
|MasterViewClose|
|CreateShortcutMenuFromMacro|
|DrawingNewClassic|
|HyperlinkInsert|
|HyperlinkEdit|
|ReviewNewComment|
|ReviewPreviousComment|
|ReviewNextComment|
|ReviewDeleteComment|
|ReviewShowOrHideComment|
|ReviewShowAllComments|
|PivotTableOptions|
|DesignMode|
|WordArtInsertDialogClassic|
|FormFieldProperties|
|PhoneticGuideEdit|
|FullScreenViewClassic|
|PhoneticGuideSettings|
|PhoneticGuideFieldShow|
|CircularReferences|
|MasterDocumentExpandOrCollapseSubdocuments|
|Chart3DConeChart|
|InternationalCurrency|
|ObjectsAlignCenterInFormHorixontally|
|ObjectsAlignCenterInFormVertically|
|SizeToControlWidth|
|SizeToControlHeight|
|SizeToControlHeightAndWidth|
|HorizontalSpacingDecrease|
|HorizontalSpacingIncrease|
|ObjectsAlignDistributeHorizontallyRemove|
|VerticalSpacingDecrease|
|VerticalSpacingIncrease|
|ObjectsAlignDistributeVerticallyRemove|
|ObjectsArrangeBottom|
|ObjectsArrangeRight|
|CancelMeeting|
|Private|
|AcceptTask|
|SaveAndNew|
|CopyFolder|
|EmptyTrash|
|RecordInJournal|
|MarkAsUnread|
|CopyToFolder|
|MoveToFolder|
|ShapeFillColorPickerClassic|
|ControlLineColorPicker|
|VisualBasic|
|DoubleBottomBorder|
|BorderThickBottom|
|BorderTopAndBottom|
|BorderTopAndDoubleBottom|
|BorderTopAndThickBottom|
|BordersAll|
|BorderThickOutside|
|SlideBackgroundFormatDialog|
|AutoSummarize|
|ViewDocumentMap|
|ReviewAcceptChange|
|ReviewRejectChange|
|TableDrawBorderPenStyle|
|Font|
|FontSize|
|ZoomClassic|
|CreateMap|
|MergeCellsAcross|
|FieldChooser|
|MessageHeaderToggle|
|MeetingRequest|
|NewNote|
|RecurrenceEdit|
|SendStatusReport|
|ImagerScan|
|QueryReturnGallery|
|SelectRecord|
|SelectAllRecords|
|TableTestValidationRules|
|RelationshipsClearLayout|
|SaveAsQuery|
|LoadFromQuery|
|DatasheetColumnRename|
|FileServerLinkTables|
|DatasheetColumnLookup|
|RecordsRefreshRecords|
|RelationshipsEditRelationships|
|RelationshipsHideTable|
|ReplicationRecoverDesignMaster|
|ReplicationResolveConflicts|
|ReplicationCreateReplica|
|ReplicationSynchronizeNow|
|SetDatabasePassword|
|DatabaseUserLevelSecurityWizard|
|DatabaseUserAndGroupAccounts|
|ControlSpecialEffectEtched|
|ControlSpecialEffectShadowed|
|ControlSpecialEffectChiseled|
|WindowsCascade|
|PositionFitToWindow|
|BorderInsideHorizontal|
|BorderInsideVertical|
|BorderDiagonalDown|
|BorderDiagonalUp|
|MagicEightBall|
|TextDirectionLeftToRight|
|TextDirectionRightToLeft|
|ActiveXCheckBox|
|FindDialogExcel|
|ActiveXTextBox|
|ActiveXButton|
|ActiveXRadioButton|
|ActiveXListBox|
|ActiveXComboBox|
|ActiveXToggleButton|
|ActiveXSpinButton|
|ActiveXScrollBar|
|ActiveXLabel|
|ShowBcc|
|ShowFrom|
|DefinePrintStyles|
|TagMarkComplete|
|NewContactFromSameCompany|
|ChooseForm|
|RecoverInviteToMeeting|
|FormPublish|
|SkipOccurrence|
|RightToLeftDocument|
|EditQuery|
|DataRangeProperties|
|RefreshAll|
|RefreshCancel|
|RefreshStatus|
|ClearAll|
|NewPostInThisFolder|
|ReplyToAttendeesWithMessage|
|SaveAndClose|
|AssignTask|
|Recurrence|
|NewMessageToContact|
|NewTaskForContact|
|NewMeetingWithContact|
|NewMessageToAttendees|
|SendUpdate|
|ReplyToAllAttendeesWithMessage|
|PostReplyToFolder|
|ViewAppointmentInCalendar|
|NewJournalEntry|
|NewMailMessage|
|CancelAcceptTask|
|CancelTaskAssignment|
|CancelDeclineTask|
|NewTaskRequest2|
|RecurrenceEditSeries|
|DataValidation|
|DataValidationCircleInvalid|
|ReviewShareWorkbook|
|ReviewTrackChanges|
|ReviewHighlightChanges|
|DatabaseQueryNew|
|DataValidationClearValidationCircles|
|ReviewEditComment|
|TableDrawTable|
|TableEraser|
|TableCellAlignTop|
|TableCellAlignCenterVertically|
|TableCellAlignBottom|
|TableColumnsDistribute|
|TableRowsDistribute|
|FileCompactAndRepairDatabase|
|DatabaseMakeMdeFile|
|DatabaseEncodeDecode|
|SizeToTallest|
|SizeToShortest|
|SizeToWidest|
|SizeToNarrowest|
|QueryUnionQuery|
|QueryDataDefinition|
|QuerySqlPassThroughQuery|
|ClearGrid|
|ActiveXFrame|
|ActiveXImage|
|ShapeConnectorStyleStraight|
|ShapeConnectorStyleElbow|
|ShapeConnectorStyleCurved|
|WordArtEditTextClassic|
|FilterByResource|
|TableInsertCellsDialog|
|DeleteCells2|
|TableDeleteRows|
|TableDeleteColumns|
|Organizer|
|ShadowOnOrOffClassic|
|MacroRecorderStop|
|FileSendAsAttachment|
|AutoSummaryViewByHighlight|
|MasterDocument|
|ChangeCase|
|ListNumFieldInsert|
|ParagraphSpaceBeforeNone|
|ParagraphSpaceBefore|
|ParagraphSpaceAddOrRemoveBefore|
|PagePreviousWord|
|PageNextWord|
|MailMergeRecepientsUseExistingList|
|FootnoteNextWord|
|EndnoteInsertWord|
|IndexMarkEntry|
|CitationMark|
|IndexInsert|
|TableOfContentsDialog|
|TableOfFiguresInsert|
|TableOfAuthoritiesInsert|
|TextBoxLinkCreate|
|TextBoxLinkBreak|
|TextBoxNextLinked|
|TextBoxPreviousLinked|
|CompareAndCombine|
|PrintOptionsMenuWord|
|PageNumberFormat|
|CancelInvitation|
|ContactWebPage|
|AttachItem|
|SendAgain|
|EditComposePage|
|EditReadPage|
|DesignThisForm|
|FileNewDefault|
|FilePrintQuick|
|WindowsTileVertically|
|WindowsTileHorizontally|
|SpellingAndGrammar|
|CopyToPersonalCalendar|
|CopyToPersonalTaskList|
|Post|
|NewOfficeDocument|
|CreateClassModule|
|ControlTabControl|
|ControlPage|
|ReviewPreviousChangeClassic|
|ReviewNextChangeClassic|
|DialMenu|
|SendDefault|
|MessageProperties|
|PictureInsertFromFile|
|TableDrawBorderPenWeight|
|FormatObject2|
|TableShowGridlines|
|TableBorderPenColorPicker|
|ShowAutoShapesAndDrawingBars|
|ShapeStraightConnectorArrow|
|ShapeElbowConnectorArrow|
|SourceControlAddObjects|
|SourceControlGetLatestVersion|
|SourceControlCheckOut|
|SourceControlCheckIn|
|SourceControlUndoCheckOut|
|SourceControlShareObjects|
|SourceControlShowDifferences|
|SourceControlShowHistory|
|SourceControlRun|
|SourceControlProperties|
|SourceControlCreateDatabaseFromProject|
|SourceControlAddDatabase|
|SourceControlOptions|
|SourceControlRefreshStatus|
|DatabaseMoveToSharePoint|
|NewPostInThisFolder3|
|SlideDelete|
|ViewHandoutMasterView|
|ViewNotesMasterView|
|SlidesReuseSlides|
|SlidesFromOutline|
|MovieFromFileInsert|
|SoundInsertFromFile|
|FontsReplaceFonts|
|SpeakerNotes|
|BlackAndWhiteAutomatic|
|BlackAndWhiteBlack|
|BlackAndWhiteBlackWithGrayscaleFill|
|BlackAndWhiteBlackWithWhiteFill|
|BlackAndWhiteDontShow|
|BlackAndWhiteGrayWithWhiteFill|
|BlackAndWhiteGrayscale|
|BlackAndWhiteInverseGrayscale|
|BlackAndWhiteWhite|
|BlackAndWhiteLightGrayscale|
|RecordNarration|
|SlideShowSetUpDialog|
|SummarizeSlide|
|TextWrappingTopAndBottom|
|TextWrappingThrough|
|MoveToFolderMenu|
|MacroRecordOrStop|
|PasteAsHyperlink|
|ParagraphDistributed|
|HyphenationOptions|
|TableRowsOrColumnsDistribute|


# **Change Tracking XE "Change tracking"  XE "Tracking changes"** 

This section identifies changes that were made to this document since the last release. Changes are classified as Major, Minor, or None. 

The revision class **Major** means that the technical content in the document was significantly revised. Major changes affect protocol interoperability or implementation. Examples of major changes are:

- A document revision that incorporates changes to interoperability requirements.

- A document revision that captures changes to protocol functionality.

The revision class **Minor** means that the meaning of the technical content was clarified. Minor changes do not affect protocol interoperability or implementation. Examples of minor changes are updates to clarify ambiguity at the sentence, paragraph, or table level.

The revision class **None** means that no new technical changes were introduced. Minor editorial and formatting changes may have been made, but the relevant technical content is identical to the last released version.

The changes made to this document are listed in the following table. For more information, please contact [dochelp@microsoft.com](mailto:dochelp@microsoft.com).
|**Section**|**Description**|**Revision class**|
|:---|:---|:---|
|[4]() Appendix B: Product Behavior|Updated list of supported products.|major|


# **Index**

***C***


[Change tracking]() PAGEREF section_7e45371b0f1d4ff6b01f2fcbef31233f523

Custom UI

   [parts]() PAGEREF section_edc80b0591694ff795ee03af067f35b19

Custom UI control id table

   [imageMso table]() PAGEREF section_fe2124a15aaa4adfb2855d58da9d5e2a419


***E***


[Elements]() PAGEREF section_d842006e31874f66a17d0819a3cc94b511

   [box (box grouping container)]() PAGEREF section_fb660d68051e4a86ab97e0d93b32817e11

   [button (button inside of a split button)]() PAGEREF section_2257e779b94944cb8ec0719a46421f3e34

   [button (button)]() PAGEREF section_846e8fb607d3460b816bbcfae841c95b15

   [button (unsized button)]() PAGEREF section_2e7b9955ff774a2f9d93401f0541e8fd25

   [buttonGroup (button grouping container)]() PAGEREF section_d9f6097943e740e6bd211f9693600c2143

   [checkBox (check box)]() PAGEREF section_d189aedcd7634295bc2b07746447dfde46

   [comboBox (combo box)]() PAGEREF section_3caf6b1834cb4352bd3177a26980c00e56

   [command (repurposed command)]() PAGEREF section_21316865fbce4a3fa9ffa8277cce5f2d67

   [commands (list of repurposed commands)]() PAGEREF section_f914543a2b8e48d4bf5e98b1326e7fc269

   [contextualTabs (list of contextual tab sets)]() PAGEREF section_75ae6d6f6a8549a2a5fb84b970d54ffb69

   [control (control clone)]() PAGEREF section_f2bf1b5d049246a488f7dc1a9528f75578

   [control (Quick Access Toolbar control clone)]() PAGEREF section_14909d674b9f4796badae79edaedcdf287

   [control (unsized control clone)]() PAGEREF section_ada8edc4b469410e8bd05d667ffe7dbf70

   [customUI (custom UI document root)]() PAGEREF section_8a27e8523f8b424aac6732c58181e9d396

   [dialogBoxLauncher (dialog box launcher)]() PAGEREF section_76d9f8786b2749ff8c4cee008f345cac97

   [documentControls (list of document-specific Quick Access Toolbar controls)]() PAGEREF section_de33fcbe3b5b4d30b875d2ec922cf32f98

   [dropDown (drop-down control)]() PAGEREF section_700e4451870640c58d7b896e4ae21b6999

   [dynamicMenu (dynamic menu)]() PAGEREF section_26d7db807ea442d09a063f63365043c7120

   [dynamicMenu (unsized dynamic menu)]() PAGEREF section_fd0825c70f294038861754af0dec8c7d111

   [editBox (edit box)]() PAGEREF section_7b552756a970466db7c2ee5bbe171e34131

   [gallery (gallery)]() PAGEREF section_017f9f94700f4846ba19c695ad32929f140

   [gallery (unsized gallery)]() PAGEREF section_7bfba338481f453e97670e0855c8f029156

   [group (group)]() PAGEREF section_190f51e63a3c4cf8affbcec9b906aae4170

   [item (selection item)]() PAGEREF section_6417edcc85b847f781fd56918e8df537178

   [labelControl (text label)]() PAGEREF section_965555a293db48a6a6bf5dd08a13f6bb181

   [menu (dynamic menu root XML element)]() PAGEREF section_e662c00135584511a56507a3e32021e3219

   [menu (menu with title)]() PAGEREF section_f785dc2b045b4b86b5424a10d264dace198

   [menu (menu)]() PAGEREF section_0243b261903e43d98e8b43f66ea0bcaf208

   [menu (unsized menu)]() PAGEREF section_1590adf87f2a4ec8944f9c4329e7ff98189

   [menuSeparator (menu separator)]() PAGEREF section_00c26e34b4a84c97a4f6d547a555a686221

   [officeMenu (Office menu)]() PAGEREF section_d9422554dbaf42e09e4b6416a80b0844224

   [qat (Quick Access Toolbar)]() PAGEREF section_93e2f741a06c40968dbf5a97fefca545225

   [ribbon (ribbon)]() PAGEREF section_574eeee87a03406ab95ff9e51e53dd9d226

   [separator (separator)]() PAGEREF section_21312cb8be0f412c8184acd533a1410b227

   [sharedControls (list of shared Quick Access Toolbar controls)]() PAGEREF section_0ca32ee5aae74ff18baa8a8c9be2ebb3230

   [splitButton (split button with title)]() PAGEREF section_1c6721206402408b96dde98650c12da5239

   [splitButton (split button)]() PAGEREF section_aa41c698c7e84486b15fb73bedbf2be8248

   [splitButton (unsized split button)]() PAGEREF section_6477dffcc8f24fc9815b637dabf3911d231

   [tab (tab)]() PAGEREF section_141f881ca5a4473f944955d3d36579ed257

   [tabs (list of tabs)]() PAGEREF section_6cbd1ae9780f421886aec536f6c0e97a261

   [tabSet (contextual tab set)]() PAGEREF section_90a00968474745128601b61440747033262

   [toggleButton (toggle button inside of a split button)]() PAGEREF section_539b9c44822d45cb8abe66b65a8bc14c283

   [toggleButton (toggle button)]() PAGEREF section_ec42bfd0149c495b895c3bc708b8a149273

   [toggleButton (unsized toggle button)]() PAGEREF section_69b127857fce431591c145aa114726ea263


***G***


[Glossary]() PAGEREF section_315de154485a48fca96e8c1a2b3209647


***I***


idMso tables

   [Excel 2007]() PAGEREF section_bb5bb594ec8c45f68424f98e8308b25a358

   [PowerPoint 2007]() PAGEREF section_f2a8e3c014cb4ad388cda8b5b1b9a8a0393

   [Word 2007]() PAGEREF section_a9f90d736e694bb78e384f268cd42038304

[Informative references]() PAGEREF section_dbe3a851c6b94ae0ba7984f1e88432d18

[Introduction]() PAGEREF section_5b5f9bab46874f838f2cb743c813e4c37


***N***


[Normative references]() PAGEREF section_ea98067859b3466892052fedb66150138


***P***


Parts

   [additional part types]() PAGEREF section_728fd283b4524a14ba8c33100cf6f0889

   [quick access toolbar customizations part]() PAGEREF section_087c607c5565418c8d31772b91d93ff39

   [ribbon extensibility part]() PAGEREF section_52faf7b6fecc48d996dbee80a631a5ac10

[Product behavior]() PAGEREF section_30685057c9f24d9c82acf3274539540f522


***R***


References

   [informative]() PAGEREF section_dbe3a851c6b94ae0ba7984f1e88432d18

   [normative]() PAGEREF section_ea98067859b3466892052fedb66150138


***S***


[Simple types]() PAGEREF section_869c8c9a45f84119b068f61e76d04322292

   [ST_BoxStyle (box style)]() PAGEREF section_3a299df5af064f4f813db0043d772546292

   [ST_Delegate (callback function name)]() PAGEREF section_188cc098eef7453e895cd96e8e99576c292

   [ST_GalleryItemWidthHeight (gallery item width or height)]() PAGEREF section_76f0a96c409d49a5927028e9b6b7f0a4295

   [ST_GalleryRowColumnCount (gallery row or column count)]() PAGEREF section_b09148682e5949dd96cfdf995849a1bf295

   [ST_ID (control identifier)]() PAGEREF section_18fbbd72e04f48148f9a45b2c4cc8393296

   [ST_ItemSize (menu item size)]() PAGEREF section_c65c8b6052e5404dad5a8c09627c60eb297

   [ST_Keytip (key tip)]() PAGEREF section_78170415e2fa4fc0899a76096fdc6aa6297

   [ST_LongString (long string)]() PAGEREF section_94ee0d879533413ebf87bbee57270f7e298

   [ST_QID (qualified control identifier)]() PAGEREF section_7c80b304b2f8432a83ee7f8ec792af0c298

   [ST_Size (control size)]() PAGEREF section_acf53d2ea68046de946752a2f4a51631300

   [ST_String (short string)]() PAGEREF section_d104fcb261774eb9a4000a5f8ddcd539301

   [ST_StringLength (string length)]() PAGEREF section_4a327c6229ec496e935fa1aa77d26d5e302
