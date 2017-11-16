using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.IO;
using System.Linq;

namespace Teach
{
	public class DPSumSlow{
		int[] nums;
		int m;
		int ans;

		public int Solve(int[] nums, int m){
			this.nums = nums;
			this.m = m;
			ans = int.MaxValue;
			return (ans == int.MaxValue) ? -1 : ans;
		}

		void Solve(int level, int k, int sum){
			// ここに書くべきコードを考えること．
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
