using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System.Linq;

namespace Teach
{
	public class DPSum{
		/// <summary>
		/// Solve the specified nums and m.
		/// </summary>
		/// <param name="nums">棒の長さ</param>
		/// <param name="m">目標値</param>
		public int Solve(int[] nums, int m){
			// 1. 棒を短い順にソーと
			// 棒の長さの配列
			var sortedNums = nums.OrderByDescending(x=>x).ToArray();
			// 2. 0を含めるため，目標値+1の要素を持つ配列を作る．
			int lengthCount = m+1;
			var dpArray = new int[lengthCount];
			// 初期化　　長さ0 の時は 棒0本
			dpArray [0] = 0;
			for (int i = 1; i < lengthCount; i++) {
				dpArray [i] = int.MaxValue;
			}


			// 3. 棒をどんどんふやしていく．
			for (int i = 0; i < sortedNums.Length; i++) {
				// lは棒の長さlengthのl, 棒の長さ分計算する
				for (int l = m; l >= 0; l--) {
					
					// 目標値から現在の棒の長さを引いた長さ
					int targetLength = l - sortedNums [i];

					// 比較する長さよりも棒の長さの方が長くなったらbreak
					if (targetLength < 0)
						break;

					// 以前の値がないときはcontinue
					if (dpArray [targetLength] == int.MaxValue)
						continue;
					int val = dpArray [targetLength] + 1; // 1本分足す

					if (dpArray [l] > val)
						dpArray [l] = val;
				}
			}
			return (dpArray[m] == int.MaxValue) ? -1 : dpArray[m];
		}
	}

	public class Kadai12b : MonoBehaviour
	{

		public TextAsset textAsset;

		void Start ()
		{
			Scanner sc = new Scanner (textAsset.text);
			DPSum sol = new DPSum ();
			while (true) {
				int m = sc.NextInt ();
				int n = sc.NextInt ();
				if (m == 0)
					break;
				int[] a = new int[n];
				for (int i = 0; i < n; i++)
					a [i] = sc.NextInt ();
				Debug.Log (sol.Solve (a, m));
			}
		}
	}
}
