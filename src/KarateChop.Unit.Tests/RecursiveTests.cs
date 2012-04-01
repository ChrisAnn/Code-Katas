using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KarateChop.Unit.Tests
{
	[TestFixture]
	public class RecursiveTests
	{
		[Test]
		public void Should_handle_empty_list()
		{
			Assert.That(KarateChop.Recursive(3, new int[0]), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_handle_not_found_in_a_list_of_one()
		{
			Assert.That(KarateChop.Recursive(3, new int[1] {1}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_find_in_a_list_of_one()
		{
			Assert.That(KarateChop.Recursive(1, new int[1] {1}), Is.EqualTo(0));
		}
		
		[Test]
		public void Should_find_first_in_a_list_of_three()
		{
			Assert.That(KarateChop.Recursive(1, new int[3] {1, 3, 5}), Is.EqualTo(0));
		}
		
		[Test]
		public void Should_second_in_a_list_of_three()
		{
			Assert.That(KarateChop.Recursive(3, new int[3] {1, 3, 5}), Is.EqualTo(1));
		}
		
		[Test]
		public void Should_third_in_a_list_of_three()
		{
			Assert.That(KarateChop.Recursive(5, new int[3] {1, 3, 5}), Is.EqualTo(2));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three()
		{
			Assert.That(KarateChop.Recursive(0, new int[3] {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three_1()
		{
			Assert.That(KarateChop.Recursive(2, new int[3] {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three_2()
		{
			Assert.That(KarateChop.Recursive(4, new int[3] {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_three_3()
		{
			Assert.That(KarateChop.Recursive(6, new int[3] {1, 3, 5}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_find_first_in_a_list_of_four()
		{
			Assert.That(KarateChop.Recursive(1, new int[4] {1, 3, 5, 7}), Is.EqualTo(0));
		}
		
		[Test]
		public void Should_find_second_in_a_list_of_four()
		{
			Assert.That(KarateChop.Recursive(3, new int[4] {1, 3, 5, 7}), Is.EqualTo(1));
		}
		
		[Test]
		public void Should_find_third_in_a_list_of_four()
		{
			Assert.That(KarateChop.Recursive(5, new int[4] {1, 3, 5, 7}), Is.EqualTo(2));
		}
		
		[Test]
		public void Should_find_fourth_in_a_list_of_four()
		{
			Assert.That(KarateChop.Recursive(7, new int[4] {1, 3, 5, 7}), Is.EqualTo(3));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_four()
		{
			Assert.That(KarateChop.Recursive(0, new int[4] {1, 3, 5, 7}), Is.EqualTo(-1));
		}

		[Test]
		public void Should_return_not_found_in_a_list_of_four_1()
		{
			Assert.That(KarateChop.Recursive(2, new int[4] {1, 3, 5, 7}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_four_2()
		{
			Assert.That(KarateChop.Recursive(4, new int[4] {1, 3, 5, 7}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_four_3()
		{
			Assert.That(KarateChop.Recursive(6, new int[4] {1, 3, 5, 7}), Is.EqualTo(-1));
		}
		
		[Test]
		public void Should_return_not_found_in_a_list_of_four_4()
		{
			Assert.That(KarateChop.Recursive(8, new int[4] {1, 3, 5, 7}), Is.EqualTo(-1));
		}
	}
}

