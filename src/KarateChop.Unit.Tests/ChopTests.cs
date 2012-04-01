using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KarateChop.Unit.Tests
{
	[TestFixture]
	public class ChopTests
	{
		[Test]
		public void Should_handle_empty_list()
		{
			Assert.That(KarateChop.Chop(3, new List<int>()), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_handle_not_found_in_a_list_of_one()
		{
			Assert.That(KarateChop.Chop(3, new List<int> {1}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_find_in_a_list_of_one()
		{
			Assert.That(KarateChop.Chop(1, new List<int> {1}), Is.EqualTo(0));
		}
		
		[Test]
		public void Should_find_first_in_a_list_of_three()
		{
			Assert.That(KarateChop.Chop(1, new List<int> {1, 3, 5}), Is.EqualTo(0));
		}
		
		[Test]
		public void Should_second_in_a_list_of_three()
		{
			Assert.That(KarateChop.Chop(3, new List<int> {1, 3, 5}), Is.EqualTo(1));
		}
		
		[Test]
		public void Should_third_in_a_list_of_three()
		{
			Assert.That(KarateChop.Chop(5, new List<int> {1, 3, 5}), Is.EqualTo(2));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three()
		{
			Assert.That(KarateChop.Chop(0, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three_1()
		{
			Assert.That(KarateChop.Chop(2, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three_2()
		{
			Assert.That(KarateChop.Chop(4, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three_3()
		{
			Assert.That(KarateChop.Chop(6, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_find_first_in_a_list_of_five()
		{
			Assert.That(KarateChop.Chop(1, new List<int> {1, 3, 5, 7}), Is.EqualTo(0));
		}
		
		[Test]
		public void Should_find_second_in_a_list_of_five()
		{
			Assert.That(KarateChop.Chop(3, new List<int> {1, 3, 5, 7}), Is.EqualTo(1));
		}
		
		[Test]
		public void Should_find_third_in_a_list_of_five()
		{
			Assert.That(KarateChop.Chop(5, new List<int> {1, 3, 5, 7}), Is.EqualTo(2));
		}
		
		[Test]
		public void Should_find_fifth_in_a_list_of_five()
		{
			Assert.That(KarateChop.Chop(7, new List<int> {1, 3, 5, 7}), Is.EqualTo(3));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_five()
		{
		    Assert.That(KarateChop.Chop(0, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		}

		[Test]
		public void Should_return_not_found_in_a_list_of_five_1()
		{
			Assert.That(KarateChop.Chop(2, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_five_2()
		{
			Assert.That(KarateChop.Chop(4, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_five_3()
		{
			Assert.That(KarateChop.Chop(6, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_five_4()
		{
		    Assert.That(KarateChop.Chop(8, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		}
	}
}

