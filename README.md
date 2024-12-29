# Spooksoft.HexEditor

A performant and elegant hexeditor control for WPF

## Added Features
- Toggle appending functionality using the `AllowAppendDocument` property.
- Control the visibility of the footer with the `IsShowFooter` property.
- Automatically refresh the control when loading data through the `LoadStream` method in the `ByteContainer` class.

## To Do
- Implement Ctrl+C to copy the selected bytes or string to the clipboard.
  - Currently, Ctrl+C copies the selected bytes regardless of whether the focus is on the hex or text section.
- Implement the Delete and Backspace keys to set the selected bytes to `0x00` when the `AllowAppendDocument` property is set to `false`.