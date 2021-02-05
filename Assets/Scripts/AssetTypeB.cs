using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Asset B")]
public class AssetTypeB : ScriptableObject
{
	public AssetTypeA SomeRef;
}
