import UIKit

class TwoFer {
    static func twoFer(name: String = "you") -> String {
        return "One for \(name), one for me."
    }
}

TwoFer.twoFer(name: "Alice")
