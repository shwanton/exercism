#!/usr/bin/env bash

set -o errexit
set -o nounset

main() {
	echo "Hello, ${1:-World}!"
}

main "$@"
