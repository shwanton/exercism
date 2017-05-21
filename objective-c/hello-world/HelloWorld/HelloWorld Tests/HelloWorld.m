//
//  HelloWorld.m
//  HelloWorld
//
//  Created by Shawn Dempsey on 5/21/17.
//  Copyright © 2017 Shawn Dempsey. All rights reserved.
//

#import "HelloWorld.h"

@implementation HelloWorld
- (NSString *)hello:(NSString *)name {
    return [NSString stringWithFormat:@"Hello, %@!", name ?: @"World"];
}
@end
