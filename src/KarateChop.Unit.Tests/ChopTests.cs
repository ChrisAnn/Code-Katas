using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace KarateChop.Unit.Tests
{
	[TestFixture]
	public class ChopTests
	{
		[Test]
		public void Should_Chop()
		{
			Assert.That(KarateChop.Chop(3, new List<int>()), Is.EqualTo(-1));
			Assert.That(KarateChop.Chop(3, new List<int> {1}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(1, new List<int> {1}), Is.EqualTo(0));
		    Assert.That(KarateChop.Chop(1, new List<int> {1, 3, 5}), Is.EqualTo(0));
		    Assert.That(KarateChop.Chop(3, new List<int> {1, 3, 5}), Is.EqualTo(1));
		    Assert.That(KarateChop.Chop(5, new List<int> {1, 3, 5}), Is.EqualTo(2));
		    Assert.That(KarateChop.Chop(0, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(2, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(4, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(6, new List<int> {1, 3, 5}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(1, new List<int> {1, 3, 5, 7}), Is.EqualTo(0));
		    Assert.That(KarateChop.Chop(3, new List<int> {1, 3, 5, 7}), Is.EqualTo(1));
		    Assert.That(KarateChop.Chop(5, new List<int> {1, 3, 5, 7}), Is.EqualTo(2));
		    Assert.That(KarateChop.Chop(7, new List<int> {1, 3, 5, 7}), Is.EqualTo(3));
		    Assert.That(KarateChop.Chop(0, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(2, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(4, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(6, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		    Assert.That(KarateChop.Chop(8, new List<int> {1, 3, 5, 7}), Is.EqualTo(-1));
		}
	}
}

