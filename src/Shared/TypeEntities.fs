namespace IronSde.Types

type internal ItemTypeGroupData = { id: int; categoryId: int }

type internal AttributeTypeData = { id: int; categoryId: int option; name: string; defaultValue: float option; }

type internal ItemTypeAttributeData = { attributeId: int; value: float option; }

type internal ItemTypeData = { id: int; groupId: int; attributes: ItemTypeAttributeData []; }

type internal MetaGroupData = { id: int; name: string; typeIds: int [] }