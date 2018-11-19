class Anagram {
  constructor(word) {
    this.word = word;
  }

  matches(list) {
    return list.reduce((acc, val, idx, arr) => {
      if (val.length !== this.word.length) return acc;
      if (/^[^a-z]*$/.test(val)) return acc;

      const contains = [...this.word.toLowerCase()].every(letter => {
        return val.toLowerCase().includes(letter);
      });

      acc = contains ? acc.concat(val) : acc;
      return acc;
    }, []);
  }
}

export default Anagram;
