const ALPHABET = 'abcdefghijklmnopqrstuvwxyz'

var Pangram = function(input) {
  this.alphabet = ALPHABET.split('');
  this.input = input.toLowerCase().replace(/ /g, '').split('');
};

Pangram.prototype.isPangram = function() {
  if (this.input.length < this.alphabet.length) {
    return false;
  }

  for (var i = 0; i < this.alphabet.length; i++) {
    var letter = this.alphabet[i];
    if (this.input.indexOf(letter) == -1) {
      return false;
    }
  }

  return true;
};

module.exports = Pangram;

