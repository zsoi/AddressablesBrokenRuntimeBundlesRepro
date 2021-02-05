using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class Bootloader : MonoBehaviour
{
	public Material Fallback;
	public Renderer MatToAssign;
	public string AddressToLoad;

	void Start()
	{
		Startup().Forget();
	}

	async UniTaskVoid Startup()
	{
		try
		{
			await Addressables.InitializeAsync();

			AssetTypeC toLoad = await Addressables.LoadAssetAsync<AssetTypeC>(AddressToLoad);

			MatToAssign.sharedMaterial = toLoad.SomeRef.SomeRef.MatRef;
		}
		catch
		{
			MatToAssign.sharedMaterial = Fallback;

			throw;
		}
	}
}
