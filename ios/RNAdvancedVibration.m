
#import "RNAdvancedVibration.h"

static const UISelectionFeedbackGenerator *generator;

@implementation RNAdvancedVibration

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE()

RCT_EXPORT_METHOD(prepare)
{
  generator = [[UISelectionFeedbackGenerator alloc] init];
  dispatch_async(dispatch_get_main_queue(), ^{
    [generator prepare];
  });
}

RCT_EXPORT_METHOD(triggerSelectionFeedback)
{
  dispatch_async(dispatch_get_main_queue(), ^{
    [generator selectionChanged];
    [generator prepare];
  });
}

@end
  
