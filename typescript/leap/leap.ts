function equallyDivisibleBy(year: number) {
  return (test: number): boolean => (year % test === 0)
}

export default (year: number): boolean => {
  const dividesEqual = equallyDivisibleBy(year)
  return (
    dividesEqual(4) &&
    (!dividesEqual(100) || dividesEqual(400))
  )
}
