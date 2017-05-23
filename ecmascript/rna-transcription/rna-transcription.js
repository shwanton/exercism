const DNA_MAP = {
  G: 'C',
  C: 'G',
  T: 'A',
  A: 'U'
}

class Transcriptor {
  toRna(target) {
    return [...target].reduce((acc, value) => {
      const result = DNA_MAP[value];
      if(!result) throw new Error('Invalid input DNA.');
      return acc.concat(result);
    }, "")
  }
}

export default Transcriptor
