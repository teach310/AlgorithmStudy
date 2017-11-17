using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System.Linq;

namespace Teach
{
	public class DPSumSlow{
		int[] nums; // 棒の長さの配列
		int m; // 目標値
		int ans; // 総重量
		public int count = 0;

		public int Solve(int[] nums, int m){
			this.nums = nums;
			this.m = m;
			ans = int.MaxValue;
			Solve (0, 0, 0);
			return (ans == int.MaxValue) ? -1 : ans;
		}

		/// <summary>
		/// Solve the specified level, k and sum.
		/// </summary>
		/// <param name="level">Level.</param>
		/// <param name="k">K.</param>
		/// <param name="sum">Sum.</param>
		void Solve(int level, int k, int sum){
			// ここに書くべきコードを考えること．
			// 最小値の更新
			if (sum == m && k < ans)
				ans = k;
			
			#region もうこれ以上計算しなくていい条件
			if (level >= nums.Length)
				return;
			if (sum >= m)
				return;
			if (k >= ans)
				return;
			#endregion


			Solve (level + 1, k + 1, sum + nums [level]);
			Solve (level + 1, k, sum);
		}
	}

	public class Kadai7 : MonoBehaviour
	{

		public TextAsset textAsset;

		void Start ()
		{
			Scanner sc = new Scanner (textAsset.text);
			DPSumSlow sol = new DPSumSlow ();
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
