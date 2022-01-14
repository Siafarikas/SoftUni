using NUnit.Framework;
using System;

namespace Gyms.Tests
{
    [TestFixture]
    public class GymsTests
    {
        [Test]
        public void Constructor_ShouldInitializeCorrectly()
        {
            Gym gym = new Gym("Pulse", 25);
            Assert.IsNotNull(gym);
        }

        [TestCase(null)]
        [TestCase("")]
        public void Constructor_ShouldThrowArgumentNullExceptionWhenNameIsNull(string name)
        {
            Assert.Throws<ArgumentNullException>(() => new Gym(name, 25));
        }

        [Test]
        public void Constructor_ShouldThrowArgumentExceptionWhenValueIsNegative()
        {
            Assert.Throws<ArgumentException>(() => new Gym("Pulse", -2));
        }

        [Test]
        public void PropertyCount_ShouldReturnZeroWhenNoElements()
        {
            Gym gym = new Gym("Pulse", 5);
            Assert.AreEqual(0, gym.Count);
        }

        [Test]
        public void PropertyCount_ShouldHaveProperCount()
        {
            Gym gym = new Gym("Pulse", 5);
            Athlete lazar = new Athlete("Lazar");
            Athlete angel = new Athlete("Angel");
            gym.AddAthlete(lazar);
            gym.AddAthlete(angel);
            Assert.AreEqual(2, gym.Count);
        }

        [Test]
        public void AddMethod_ShouldThrowInvalidOperationExceptionWhenFull()
        {
            Gym gym = new Gym("Pulse", 1);
            Athlete lazar = new Athlete("Lazar");
            gym.AddAthlete(lazar);
            Athlete angel = new Athlete("Angel");
            Assert.Throws<InvalidOperationException>(() => gym.AddAthlete(angel));
        }

        [Test]
        public void RemoveAthlete_ShouldThrowInvalidOperationExceptionWhenAthleteDoesntExist()
        {
            Gym gym = new Gym("Pulse", 1);
            Athlete lazar = new Athlete("Lazar");
            gym.AddAthlete(lazar);

            Assert.Throws<InvalidOperationException>(() => gym.RemoveAthlete("Angel"));
        }

        [Test]
        public void RemoveAthlete_ShouldRemoveCorrectly()
        {
            Gym gym = new Gym("Pulse", 1);
            Athlete lazar = new Athlete("Lazar");
            gym.AddAthlete(lazar);
            gym.RemoveAthlete("Lazar");
            Assert.AreEqual(0, gym.Count);
        }

        [Test]
        public void InjureAthlete_ShouldThrowInvalidOperationExceptionWhenAthleteDoesntExist()
        {
            Gym gym = new Gym("Pulse", 1);
            Athlete lazar = new Athlete("Lazar");
            gym.AddAthlete(lazar);

            Assert.Throws<InvalidOperationException>(() => gym.InjureAthlete("Angel"));
        }

        [Test]
        public void InjureAthlete_ShouldInjureAthleteProperly()
        {
            Gym gym = new Gym("Pulse", 1);
            Athlete lazar = new Athlete("Lazar");
            gym.AddAthlete(lazar);
            var athlete = gym.InjureAthlete("Lazar");
            athlete.IsInjured = true;

            Assert.IsTrue(athlete.IsInjured);
        }

        [Test]
        public void Report_ShouldReturnZeroWhenNoAthletes()
        {
            Gym gym = new Gym("Pulse", 1);

            var expectedRes = $"Active athletes at Pulse: ";

            Assert.AreEqual(expectedRes, gym.Report());
        }

        [Test]
        public void Report_ShouldWorkProperly()
        {
            Gym gym = new Gym("Pulse", 2);
            Athlete lazar = new Athlete("Lazar");
            gym.AddAthlete(lazar);
            Athlete angel = new Athlete("Angel");
            gym.AddAthlete(angel);

            var expectedRes = $"Active athletes at Pulse: Lazar, Angel";

            Assert.AreEqual(expectedRes, gym.Report());
        }


    }
}
