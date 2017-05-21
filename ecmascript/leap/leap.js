class Leap {
  constructor(year) {
    this.year = year;
  }

  isLeap() {
    const dividesEqually = this.equallyDivisibleBy(this.year)
    return (
      dividesEqually(4) &&
      (!dividesEqually(100) || dividesEqually(400))
    )
  }

  equallyDivisibleBy(year) {
    return check => year % check === 0;
  }
}

export default Leap

