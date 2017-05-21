var DnaTranscriber = function() {
  this.standard = {
    G: 'C',
    C: 'G',
    T: 'A',
    A: 'U',
  }
};

DnaTranscriber.prototype.toRna = function(target) {
  var result = []
  for(i = 0; i < target.length; i++) {
    var char = target[i];
    var standardChar = this.standard[char]
    if (!standardChar) {
      throw new Error('Invalid input')
    }
    result.push(standardChar);
  }
  return result.join('');
}

module.exports = DnaTranscriber;
