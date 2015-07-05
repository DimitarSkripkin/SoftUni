using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fraction_Calculator
{
	public struct Fraction
	{
		//private const long NumeratorDefaultValue = 0;
		private const long DenominatorDefaultValue = 1;

		private long numerator, denominator;
		
		public Fraction(long numerator, long denominator = DenominatorDefaultValue)
			: this()
		{
			this.Numerator = numerator;
			this.Denominator = denominator;
		}

		public long Numerator
		{
			get
			{
				return this.numerator;
			}
			set
			{
				this.numerator = value;
			}
		}

		public long Denominator
		{
			get
			{
				return this.denominator;
			}
			set
			{
				if (value == 0)
				{
					throw new ArgumentException("denominator can't be 0");
				}
				this.denominator = value;
			}
		}

		public static Fraction operator +(Fraction a, Fraction b)
		{
			long lcm = LCM(a.denominator, b.denominator);
			return new Fraction((a.numerator * (lcm / a.denominator)) + (b.numerator * (lcm / b.denominator)), lcm);
		}

		public static Fraction operator -(Fraction a, Fraction b)
		{
			long lcm = LCM(a.denominator, b.denominator);
			return new Fraction((a.numerator * (lcm / a.denominator)) - (b.numerator * (lcm / b.denominator)), lcm);
		}

		public override string ToString()
		{
			return ((double)numerator / denominator).ToString();
		}

		private static long GCD(long m, long n)
		{
			long tmp;
			while (m != 0)
			{
				tmp = m;
				m = n % m;
				n = tmp;
			}
			return n;
		}

		private static long LCM(long m, long n)
		{
			return m / GCD(m, n) * n;
		}
	}
}
