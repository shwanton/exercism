class Anagram {
  constructor(word) {
    this.word = word;

    this.isAnagram = this.isAnagram.bind(this);
  }

  sortChars(word) {
    return word
      .toLowerCase()
      .split("")
      .sort()
      .join("");
  }

  isAnagram(candidate) {
    return (
      this.sortChars(this.word) === this.sortChars(candidate) &&
      this.word.toLowerCase() !== candidate.toLowerCase()
    );
  }

  matches(candidates) {
    return candidates.filter(this.isAnagram);
  }
}

export default Anagram;
