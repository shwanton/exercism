class Hamming
  def self.compute(a, b)
    raise ArgumentError unless (a.length == b.length)

    return a.chars.each_with_index.reduce(0) do |acc, (value, index)|
      value == b[index] ? acc : acc += 1
    end
  end
end

module BookKeeping
  VERSION = 3
end
