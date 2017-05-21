const DNA_MAP = {
  G: 'C',
  C: 'G',
  T: 'A',
  A: 'U',
}

const DnaTranscriber = function() { };

DnaTranscriber.prototype.toRna = function(target) {
  const result = target.split('').map(function(char) {
    const found = DNA_MAP[char]
    if (!found) { throw new Error('Invalid input') }

    return found
  })

  return result.join('')
}

module.exports = DnaTranscriber;
