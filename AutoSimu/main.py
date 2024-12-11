import pyperclip
import language_tool_python
import time

def main():
    tool = language_tool_python.LanguageTool('de-DE')  # Load German language tool
    last_clipboard_content = ""

    print("Press Ctrl+C to copy text and check its spelling...")

    try:
        while True:
            clipboard_content = pyperclip.paste()
            
            # Check if clipboard content has changed
            if clipboard_content != last_clipboard_content:
                last_clipboard_content = clipboard_content
                
                if clipboard_content.strip():
                    print("\nOriginal Text:\n", clipboard_content)
                    
                    # Check and correct the text
                    matches = tool.check(clipboard_content)
                    corrected_text = language_tool_python.utils.correct(clipboard_content, matches)
                    
                    print("\nCorrected Text:\n", corrected_text)
            
            time.sleep(0.5)  # Poll every 500ms to check clipboard content
            
    except KeyboardInterrupt:
        print("\nProgram exited.")

if __name__ == "__main__":
    main()
