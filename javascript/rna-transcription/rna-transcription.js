var DNA_MAP = {
  G: 'C',
  C: 'G',
  T: 'A',
  A: 'U',
}

var DnaTranscriber = function() {};

DnaTranscriber.prototype.toRna = function(target) {
  var result = []
  for(i = 0; i < target.length; i++) {
    var char = target[i];
    var standardChar = DNA_MAP[char]
    if (!standardChar) {
      throw new Error('Invalid input')
    }
    result.push(standardChar);
  }
  return result.join('');
}

module.exports = DnaTranscriber;
